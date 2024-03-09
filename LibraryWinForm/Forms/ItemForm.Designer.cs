using System.ComponentModel;
using PdfiumViewer;

namespace LibraryWinForm.Forms;

partial class ItemForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        lblBookName = new Label();
        lblBookDescription = new Label();
        lblBookAuthor = new Label();
        lblBookIsAvailable = new Label();
        lblBookAvailable = new Label();
        lblBookAvailableNumber = new Label();
        lblBookCategory1 = new Label();
        lblBookCategory2 = new Label();
        lblMissingBooksWarning = new Label();
        pdfViewer = new PdfViewer();
        SuspendLayout();
        // 
        // lblBookName
        // 
        lblBookName.AutoSize = true;
        lblBookName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblBookName.ForeColor = Color.DarkBlue;
        lblBookName.Location = new Point(20, 20);
        lblBookName.Name = "lblBookName";
        lblBookName.Size = new Size(67, 25);
        lblBookName.TabIndex = 0;
        lblBookName.Text = "Назва";
        // 
        // lblBookDescription
        // 
        lblBookDescription.AutoSize = true;
        lblBookDescription.Font = new Font("Segoe UI", 14F);
        lblBookDescription.ForeColor = Color.DimGray;
        lblBookDescription.Location = new Point(20, 120);
        lblBookDescription.MaximumSize = new Size(450, 0);
        lblBookDescription.Name = "lblBookDescription";
        lblBookDescription.Size = new Size(435, 75);
        lblBookDescription.TabIndex = 1;
        lblBookDescription.Text = "опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис ";
        // 
        // lblBookAuthor
        // 
        lblBookAuthor.AutoSize = true;
        lblBookAuthor.Font = new Font("Segoe UI", 14F);
        lblBookAuthor.ForeColor = Color.Indigo;
        lblBookAuthor.Location = new Point(20, 50);
        lblBookAuthor.Name = "lblBookAuthor";
        lblBookAuthor.Size = new Size(64, 25);
        lblBookAuthor.TabIndex = 2;
        lblBookAuthor.Text = "Автор";
        // 
        // lblBookIsAvailable
        // 
        lblBookIsAvailable.AutoSize = true;
        lblBookIsAvailable.Font = new Font("Segoe UI", 14F);
        lblBookIsAvailable.ForeColor = Color.DarkBlue;
        lblBookIsAvailable.Location = new Point(175, 850);
        lblBookIsAvailable.Name = "lblBookIsAvailable";
        lblBookIsAvailable.Size = new Size(0, 25);
        lblBookIsAvailable.TabIndex = 3;
        // 
        // lblBookAvailable
        // 
        lblBookAvailable.AutoSize = true;
        lblBookAvailable.Font = new Font("Segoe UI", 14F);
        lblBookAvailable.ForeColor = Color.DarkBlue;
        lblBookAvailable.Location = new Point(20, 850);
        lblBookAvailable.Name = "lblBookAvailable";
        lblBookAvailable.Size = new Size(122, 25);
        lblBookAvailable.TabIndex = 4;
        lblBookAvailable.Text = "В наявності: ";
        // 
        // lblBookAvailableNumber
        // 
        lblBookAvailableNumber.AutoSize = true;
        lblBookAvailableNumber.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblBookAvailableNumber.ForeColor = Color.Crimson;
        lblBookAvailableNumber.Location = new Point(140, 850);
        lblBookAvailableNumber.Name = "lblBookAvailableNumber";
        lblBookAvailableNumber.Size = new Size(32, 25);
        lblBookAvailableNumber.TabIndex = 5;
        lblBookAvailableNumber.Text = "Ні";
        // 
        // lblBookCategory1
        // 
        lblBookCategory1.AutoSize = true;
        lblBookCategory1.Font = new Font("Segoe UI", 14F);
        lblBookCategory1.ForeColor = Color.DarkBlue;
        lblBookCategory1.Location = new Point(20, 80);
        lblBookCategory1.Name = "lblBookCategory1";
        lblBookCategory1.Size = new Size(104, 25);
        lblBookCategory1.TabIndex = 6;
        lblBookCategory1.Text = "Категорія: ";
        // 
        // lblBookCategory2
        // 
        lblBookCategory2.AutoSize = true;
        lblBookCategory2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblBookCategory2.ForeColor = Color.Teal;
        lblBookCategory2.Location = new Point(120, 80);
        lblBookCategory2.Name = "lblBookCategory2";
        lblBookCategory2.Size = new Size(101, 25);
        lblBookCategory2.TabIndex = 7;
        lblBookCategory2.Text = "Категорія";
        // 
        // lblMissingBooksWarning
        // 
        lblMissingBooksWarning.AutoSize = true;
        lblMissingBooksWarning.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
        lblMissingBooksWarning.ForeColor = Color.Crimson;
        lblMissingBooksWarning.Location = new Point(600, 40);
        lblMissingBooksWarning.Name = "lblMissingBooksWarning";
        lblMissingBooksWarning.Size = new Size(478, 25);
        lblMissingBooksWarning.TabIndex = 8;
        lblMissingBooksWarning.Text = "Перегляд книг недоступний (немає книг у базі даних)";
        // 
        // pdfViewer
        // 
        pdfViewer.Location = new Point(600, 40);
        pdfViewer.Margin = new Padding(4, 3, 4, 3);
        pdfViewer.Name = "pdfViewer";
        pdfViewer.Size = new Size(686, 505);
        pdfViewer.TabIndex = 9;
        // 
        // ItemForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(493, 261);
        Controls.Add(lblBookName);
        Controls.Add(lblBookDescription);
        Controls.Add(lblBookAuthor);
        Controls.Add(lblBookIsAvailable);
        Controls.Add(lblBookAvailable);
        Controls.Add(lblBookAvailableNumber);
        Controls.Add(lblBookCategory1);
        Controls.Add(lblBookCategory2);
        Controls.Add(lblMissingBooksWarning);
        Controls.Add(pdfViewer);
        Name = "ItemForm";
        Text = "Книга";
        Load += ItemForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblBookName;
    private Label lblBookDescription;
    private Label lblBookAuthor;
    private Label lblBookAvailableNumber;
    private Label lblBookAvailable;
    private Label lblBookIsAvailable;
    private Label lblBookCategory1;
    private Label lblBookCategory2;
    private Label lblMissingBooksWarning;
    private PdfViewer pdfViewer;
}