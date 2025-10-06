using ViDu;

public class Program
{
    public static void Main(string[] args)
    {
        // Tạo thư mục gốc
        Folder root = new Folder("Root");

        // Thêm các file vào root
        root.Add(new Files("Resume.docx"));
        root.Add(new Files("Photo.png"));

        // Tạo thư mục con Documents
        Folder documents = new Folder("Documents");
        documents.Add(new Files("Report.pdf"));
        documents.Add(new Files("Invoice.xlsx"));

        // Thêm thư mục Documents vào root
        root.Add(documents);

        // Tạo thư mục con Projects trong Documents
        Folder projects = new Folder("Projects");
        projects.Add(new Files("GameProject.csproj"));
        projects.Add(new Files("BridgePattern.txt"));

        documents.Add(projects);

        // Hiển thị cấu trúc cây thư mục
        root.Display(1);

        Console.ReadKey();
    }
}