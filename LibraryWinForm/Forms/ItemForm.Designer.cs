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
        
        lblBookName.AutoSize = true;
        lblBookName.Font = FontSettings.Bold;
        lblBookName.ForeColor = Color.DarkBlue;
        lblBookName.Location = new Point(20, 20);
        lblBookName.Name = "lblBookName";
        lblBookName.Text = "Назва";
        
        lblBookAuthor.AutoSize = true;
        lblBookAuthor.Font = FontSettings.Regular;
        lblBookAuthor.ForeColor = Color.Indigo;
        lblBookAuthor.Location = new Point(20, 50);
        lblBookAuthor.Name = "lblBookAuthor";
        lblBookAuthor.Text = "Автор";
        
        lblBookCategory1.AutoSize = true;
        lblBookCategory1.Font = FontSettings.Regular;
        lblBookCategory1.ForeColor = Color.DarkBlue;
        lblBookCategory1.Location = new Point(20, 80);
        lblBookCategory1.Name = "lblBookCategory1";
        lblBookCategory1.Text = "Категорія: ";
        
        lblBookCategory2.AutoSize = true;
        lblBookCategory2.Font = FontSettings.Bold;
        lblBookCategory2.ForeColor = Color.Teal;
        lblBookCategory2.Location = new Point(120, 80);
        lblBookCategory2.Name = "lblBookCategory1";
        lblBookCategory2.Text = "Категорія";
        
        lblBookDescription.AutoSize = true;
        lblBookDescription.Font = FontSettings.Regular;
        lblBookDescription.ForeColor = Color.DimGray;
        lblBookDescription.Location = new Point(20, 120);
        lblBookDescription.MaximumSize = new Size(450, 0);
        lblBookDescription.Name = "lblBookDescription";
        lblBookDescription.Text = "опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис опис ";
        
        lblBookAvailable.AutoSize = true;
        lblBookAvailable.Font = FontSettings.Regular;
        lblBookAvailable.ForeColor = Color.DarkBlue;
        lblBookAvailable.Location = new Point(20, 850);
        lblBookAvailable.Name = "lblBookAvailable";
        lblBookAvailable.Text = "В наявності: ";
        
        lblBookAvailableNumber.AutoSize = true;
        lblBookAvailableNumber.Font = FontSettings.Bold;
        lblBookAvailableNumber.ForeColor = Color.Crimson;
        lblBookAvailableNumber.Location = new Point(140, 850);
        lblBookAvailableNumber.Name = "lblBookAvailableNumber";
        lblBookAvailableNumber.Text = "Ні";
        
        lblBookIsAvailable.AutoSize = true;
        lblBookIsAvailable.Font = FontSettings.Regular;
        lblBookIsAvailable.ForeColor = Color.DarkBlue;
        lblBookIsAvailable.Location = new Point(175, 850);
        lblBookIsAvailable.Name = "lblBookIsAvailable";
        lblBookIsAvailable.Text = "";

        lblMissingBooksWarning.AutoSize = true;
        lblMissingBooksWarning.Font = FontSettings.Italic;
        lblMissingBooksWarning.ForeColor = Color.Crimson;
        lblMissingBooksWarning.Location = new Point(600, 40);
        lblMissingBooksWarning.Name = "lblMissingBooksWarning";
        lblMissingBooksWarning.Text = "Перегляд книг недоступний (немає книг у базі даних)";

        pdfViewer.Location = new Point(600, 40);
        pdfViewer.Name = "pdfViewer";
        pdfViewer.MinimumSize = pdfViewer.Size = pdfViewer.ClientSize = pdfViewer.MaximumSize = 
            new Size(850, 800);
        
        
        components = new System.ComponentModel.Container();
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        Load += ItemForm_Load;
        MinimumSize = ClientSize = MaximumSize = new System.Drawing.Size(1400, 950);
        Text = "Книга";
        
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