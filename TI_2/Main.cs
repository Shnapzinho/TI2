using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections;
using System.Windows.Forms;

namespace TI2;

public partial class Main : Form
{
    readonly Cipher cipher = new();
    public Main()
    {
        InitializeComponent();
    }

    void ResultButton_Click(object sender, EventArgs e)
    {
        RegisterTextBox.Text = string.Join("", RegisterTextBox.Text.Where(x => x is '0' or '1'));
        if (RegisterTextBox.Text.Length != 34)
        {
            MessageBox.Show("Размерность регистра должна равняться 34", "Внимание");
            return;
        }

        if (PlainTextBox.Text.Length is 0)
        {
            MessageBox.Show("Выберите файл с исходным текстом для шифрования/дешифрования!", "Внимание");
            return;
        }
        
        cipher.ProcessBitRegister(RegisterTextBox.Text);
        cipher.GenerateBitKey(cipher.PlainText.Length);
        KeyTextBox.Text = BitArrayToString(cipher.BitKey);
        cipher.CipherAlg();
        CipherTextBox.Text = BitArrayToString(cipher.CipherBit);
    }
	void RegisterTextBox_TextChanged(object sender, EventArgs e)
	{
		LengthLabel.Text = $@"Текущая размерность регистра: {RegisterTextBox.Text.Count(x => x is '0' or '1')}";
	}

	string BitArrayToString(BitArray bitArray)
	{
		StringBuilder resultBuilder = new();
		if (bitArray.Length <= 136)
		{
			foreach (bool bit in bitArray)
			{
				resultBuilder.Append(bit ? 1 : 0);
			}
		}
		else
		{
			resultBuilder.Append("Первые 68 бит: \n");
			for (int i = 0; i < 68; i++)
				resultBuilder.Append(bitArray[i] ? 1 : 0);
			resultBuilder.Append($"{Environment.NewLine}Последние 68 бит: \n");
			for (int i = 68; i > 0; i--)
			{
				resultBuilder.Append(bitArray[bitArray.Length - i] ? 1 : 0);
			}
		}
		return resultBuilder.ToString();
	}

	private void OpenButton_Click(object sender, EventArgs e)
	{
		if (OpenFileDialog.ShowDialog() != DialogResult.Cancel)
		{
			StringBuilder stringBuilder = new();

			var bytes = File.ReadAllBytes(OpenFileDialog.FileName);
			for (int i = 0; i < bytes.Length; i++)
			{
				BitArray bitArr = new([bytes[i]]);
				foreach (bool bit in bitArr)
				{
					stringBuilder.Append(bit ? 1 : 0);
				}
			}
			cipher.PlainText = new BitArray(stringBuilder.Length);
			for (int i = 0; i < cipher.PlainText.Length; i++)
			{
				cipher.PlainText[i] = stringBuilder[i] == '1';
			}

			PlainTextBox.Text = BitArrayToString(cipher.PlainText);
		}
	}

	private void SaveButton_Click(object sender, EventArgs e)
	{
		if (SaveFileDialog.ShowDialog() != DialogResult.Cancel)
		{
			using FileStream fileStream = new(SaveFileDialog.FileName, FileMode.Create);
			byte[] result = new byte[cipher.CipherBit.Count / 8];
			cipher.CipherBit.CopyTo(result, 0);
			fileStream.Write(result, 0, result.Length);
		}
	}

	private void ClearButton_Click(object sender, EventArgs e)
	{
		KeyTextBox.Clear();
		CipherTextBox.Clear();
		PlainTextBox.Clear();
	}
}