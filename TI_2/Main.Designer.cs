namespace TI2;

partial class Main
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}

		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.ResultButton = new System.Windows.Forms.Button();
			this.RegisterTextBox = new System.Windows.Forms.TextBox();
			this.LabelRegister = new System.Windows.Forms.Label();
			this.PlainTextBox = new System.Windows.Forms.TextBox();
			this.PlainLabel = new System.Windows.Forms.Label();
			this.KeyTextBox = new System.Windows.Forms.TextBox();
			this.KeyLabel = new System.Windows.Forms.Label();
			this.CipherTextBox = new System.Windows.Forms.TextBox();
			this.LabelCipherText = new System.Windows.Forms.Label();
			this.LengthLabel = new System.Windows.Forms.Label();
			this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SaveButton = new System.Windows.Forms.Button();
			this.OpenButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ResultButton
			// 
			this.ResultButton.BackColor = System.Drawing.SystemColors.Window;
			this.ResultButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ResultButton.Location = new System.Drawing.Point(252, 60);
			this.ResultButton.Name = "ResultButton";
			this.ResultButton.Size = new System.Drawing.Size(105, 41);
			this.ResultButton.TabIndex = 3;
			this.ResultButton.Text = "Зашифровать/Дешифровать";
			this.ResultButton.UseVisualStyleBackColor = false;
			this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
			// 
			// RegisterTextBox
			// 
			this.RegisterTextBox.Location = new System.Drawing.Point(174, 12);
			this.RegisterTextBox.Multiline = true;
			this.RegisterTextBox.Name = "RegisterTextBox";
			this.RegisterTextBox.Size = new System.Drawing.Size(618, 42);
			this.RegisterTextBox.TabIndex = 4;
			this.RegisterTextBox.TextChanged += new System.EventHandler(this.RegisterTextBox_TextChanged);
			// 
			// LabelRegister
			// 
			this.LabelRegister.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.LabelRegister.Location = new System.Drawing.Point(9, 3);
			this.LabelRegister.Name = "LabelRegister";
			this.LabelRegister.Size = new System.Drawing.Size(160, 57);
			this.LabelRegister.TabIndex = 5;
			this.LabelRegister.Text = "Начальное состояние регистра (размерность 34):";
			this.LabelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PlainTextBox
			// 
			this.PlainTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.PlainTextBox.Location = new System.Drawing.Point(174, 107);
			this.PlainTextBox.Multiline = true;
			this.PlainTextBox.Name = "PlainTextBox";
			this.PlainTextBox.ReadOnly = true;
			this.PlainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.PlainTextBox.Size = new System.Drawing.Size(620, 110);
			this.PlainTextBox.TabIndex = 6;
			// 
			// PlainLabel
			// 
			this.PlainLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PlainLabel.Location = new System.Drawing.Point(22, 140);
			this.PlainLabel.Name = "PlainLabel";
			this.PlainLabel.Size = new System.Drawing.Size(120, 50);
			this.PlainLabel.TabIndex = 7;
			this.PlainLabel.Text = "Исходный текст:";
			this.PlainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// KeyTextBox
			// 
			this.KeyTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.KeyTextBox.Location = new System.Drawing.Point(174, 234);
			this.KeyTextBox.Multiline = true;
			this.KeyTextBox.Name = "KeyTextBox";
			this.KeyTextBox.ReadOnly = true;
			this.KeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.KeyTextBox.Size = new System.Drawing.Size(620, 110);
			this.KeyTextBox.TabIndex = 8;
			// 
			// KeyLabel
			// 
			this.KeyLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.KeyLabel.Location = new System.Drawing.Point(8, 255);
			this.KeyLabel.Name = "KeyLabel";
			this.KeyLabel.Size = new System.Drawing.Size(160, 52);
			this.KeyLabel.TabIndex = 9;
			this.KeyLabel.Text = "Сгенерированный ключ:";
			this.KeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CipherTextBox
			// 
			this.CipherTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.CipherTextBox.Location = new System.Drawing.Point(174, 367);
			this.CipherTextBox.Multiline = true;
			this.CipherTextBox.Name = "CipherTextBox";
			this.CipherTextBox.ReadOnly = true;
			this.CipherTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.CipherTextBox.Size = new System.Drawing.Size(620, 110);
			this.CipherTextBox.TabIndex = 10;
			// 
			// LabelCipherText
			// 
			this.LabelCipherText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelCipherText.Location = new System.Drawing.Point(8, 395);
			this.LabelCipherText.Name = "LabelCipherText";
			this.LabelCipherText.Size = new System.Drawing.Size(156, 55);
			this.LabelCipherText.TabIndex = 11;
			this.LabelCipherText.Text = "Зашифрованный текст:";
			this.LabelCipherText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LengthLabel
			// 
			this.LengthLabel.ForeColor = System.Drawing.SystemColors.Desktop;
			this.LengthLabel.Location = new System.Drawing.Point(9, 63);
			this.LengthLabel.Name = "LengthLabel";
			this.LengthLabel.Size = new System.Drawing.Size(198, 41);
			this.LengthLabel.TabIndex = 12;
			// 
			// OpenFileDialog
			// 
			this.OpenFileDialog.FileName = "openFileDialog1";
			// 
			// SaveButton
			// 
			this.SaveButton.BackColor = System.Drawing.SystemColors.Window;
			this.SaveButton.Location = new System.Drawing.Point(482, 60);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(121, 41);
			this.SaveButton.TabIndex = 17;
			this.SaveButton.Text = "Сохранить в файл";
			this.SaveButton.UseVisualStyleBackColor = false;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// OpenButton
			// 
			this.OpenButton.BackColor = System.Drawing.SystemColors.Window;
			this.OpenButton.Location = new System.Drawing.Point(359, 60);
			this.OpenButton.Name = "OpenButton";
			this.OpenButton.Size = new System.Drawing.Size(121, 41);
			this.OpenButton.TabIndex = 18;
			this.OpenButton.Text = "Открыть файл";
			this.OpenButton.UseVisualStyleBackColor = false;
			this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.BackColor = System.Drawing.SystemColors.Window;
			this.ClearButton.Location = new System.Drawing.Point(605, 60);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(121, 41);
			this.ClearButton.TabIndex = 19;
			this.ClearButton.Text = "Очистить поля";
			this.ClearButton.UseVisualStyleBackColor = false;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(807, 484);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.OpenButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.CipherTextBox);
			this.Controls.Add(this.LabelCipherText);
			this.Controls.Add(this.PlainLabel);
			this.Controls.Add(this.PlainTextBox);
			this.Controls.Add(this.KeyLabel);
			this.Controls.Add(this.RegisterTextBox);
			this.Controls.Add(this.KeyTextBox);
			this.Controls.Add(this.ResultButton);
			this.Controls.Add(this.LabelRegister);
			this.Controls.Add(this.LengthLabel);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(15, 15);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ТИ2 Студент";
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	private System.Windows.Forms.SaveFileDialog SaveFileDialog;
	private System.Windows.Forms.OpenFileDialog OpenFileDialog;

	private System.Windows.Forms.Label LengthLabel;

	private System.Windows.Forms.Label LabelCipherText;

	private System.Windows.Forms.TextBox CipherTextBox;

	private System.Windows.Forms.Label KeyLabel;

	private System.Windows.Forms.TextBox KeyTextBox;

	private System.Windows.Forms.Label PlainLabel;

	private System.Windows.Forms.TextBox PlainTextBox;

	private System.Windows.Forms.Label LabelRegister;

	private System.Windows.Forms.TextBox RegisterTextBox;

	private System.Windows.Forms.Button ResultButton;

	#endregion

	private System.Windows.Forms.Button SaveButton;
	private System.Windows.Forms.Button OpenButton;
	private System.Windows.Forms.Button ClearButton;
}