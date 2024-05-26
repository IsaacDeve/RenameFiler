namespace RenameFiler
{
    public partial class Form1 : Form
    {
        string pathTo;
        string renameTo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PathToString_TextChanged(object sender, EventArgs e)
        {

        }

        private void RenameToString_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoButton_Click(object sender, EventArgs e)
        {
            try
            {
                int counter = 1;
                pathTo = PathToString.Text;
                renameTo = RenameToString.Text;

                var files = Directory.GetFiles(pathTo);
                foreach (var file in files)
                {
                    string newName = $"{Path.Combine(pathTo, renameTo)}_{counter}{Path.GetExtension(file)}";
                    File.Move(file, newName);
                    Console.WriteLine($"Renamed file {file} successfully");
                    counter++;
                }
                Console.WriteLine("Operation done");
            }
            catch
            {
                Console.WriteLine("Couldn't rename files");
            }
        }
    }
}
