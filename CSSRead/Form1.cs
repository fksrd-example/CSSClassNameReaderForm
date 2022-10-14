namespace CSSRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Path.Text = openFileDialog.FileName.ToString();

                StreamReader sr = new StreamReader(openFileDialog.FileName);

                String Line;
                CSSParser.Parser parser = new CSSParser.Parser();
                while ((Line = sr.ReadLine()) != null)
                {
                    parser.LineParser(Line);
                }

                sr.Close();

                for (int i = 0; i < parser.cssDataType.cssClassDataTypes.Count; i++)
                {
                    DataList.Items.Add(parser.cssDataType.cssClassDataTypes[i].Name);
                }


            }
        }
    }
}