using LibraryWinForm.Data;
using LibraryWinForm.Data.Entities;
using PdfiumViewer;

namespace LibraryWinForm.Forms;

public partial class ItemForm : Form
{
    public int BookId { get; set; } = 1;
    private BookEntity book;
    

    public ItemForm()
    {
        InitializeComponent();
    }

    private void ItemForm_Load(object sender, EventArgs e)
    {
        // LibraryContext libraryContext = new();
        // book = libraryContext.Books.SingleOrDefault(b => b.BookId == BookId);
        // Поки не працює, бо в базі даних нема книг
        // LoadPdf(File.ReadAllBytes(book.PDFFile));
    }
    
    private void LoadPdf(byte[] pdfBytes)
    {
        var stream = new MemoryStream(pdfBytes);
        pdfViewer.Document = PdfDocument.Load(stream);
    }
}