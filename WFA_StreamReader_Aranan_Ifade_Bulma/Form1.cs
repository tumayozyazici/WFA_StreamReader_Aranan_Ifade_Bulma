using System.Text;

namespace WFA_StreamReader_Aranan_Ifade_Bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("C:\\Users\\--\\Desktop\\deneme.txt");
            StringBuilder sb = new StringBuilder();
            string line = string.Empty;
            do
            {
                line = sr.ReadLine();
                sb.Append(line);

            } while (line != null);
            rtxt_find.Text = sb.ToString();
            sr.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            string searchWord = txt_search.Text;
            if (searchWord != null && searchWord.Length > 0)
            {
                bool isFind = rtxt_find.Text.ToLower().Contains(searchWord.ToLower());

                if (isFind)
                {
                    WordPaint(rtxt_find, searchWord, Color.Yellow);
                }
                else
                {
                    MessageBox.Show("Aramak istediðiniz ifadeyi tekrar giriniz.");
                    txt_search.Clear();
                }
            }
            else
            {
                MessageBox.Show("Boþ geçilemez.");
            }
        }
        private void WordPaint(RichTextBox rtx_find, string searchWord, Color color)
        {
            int index = 0, startIndex = 0;
            do
            {
                index = rtxt_find.Text.IndexOf(searchWord.ToLower(),startIndex);
                if (index == -1)             // Bunu yapmazsak 60. satýrda ArgumentOutOfRangeException yiyoruz. o satýra gelmeden biz manual olarak döngüyü kýrýyoruz.
                {
                    break;
                }
                rtxt_find.Select(index,searchWord.Length);
                rtxt_find.SelectionColor = color;
                startIndex = index + searchWord.Length;

            } while (index != -1);
        }
    }
}
