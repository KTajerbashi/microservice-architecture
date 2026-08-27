using Grpc.Net.Client;
using GRPC_App.Protos;

namespace GRPC_Form_App
{
    public partial class MainForm : Form
    {
        GrpcChannel channel;
        ProductService.ProductServiceClient client;

        public MainForm()
        {
            InitializeComponent();

            channel = GrpcChannel.ForAddress("https://localhost:7200");
            client = new ProductService.ProductServiceClient(channel);
        }

        private void onLoadProduct()
        {
            ResetAllTextBoxes();
            var response = client.GetAllProduct(new RequestAllProductDTO()
            {
                Page = 1,
                PageSize = 20
            });

            datagrid_product.DataSource = response.Items;
        }
        private void ResetAllTextBoxes()
        {
            brand_txt.Text = string.Empty;
            name_txt.Text = string.Empty;
            price_txt.Text = string.Empty;
        }
        private void savechange_btn_Click(object sender, EventArgs e)
        {
            client.AddNewProduct(new RequestAddProductDTO()
            {
                Brand = brand_txt.Text,
                Name = name_txt.Text,
                Price = Convert.ToInt32(price_txt.Text),
            });
            onLoadProduct();
        }

        private void getData_btn_Click(object sender, EventArgs e)
        {
            onLoadProduct();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            string query = search_txt.Text;
            var response = client.SearchProduct(new RequestQueryProductDTO()
            {
                Query = query
            });
            datagrid_product.DataSource = response.Items;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            onLoadProduct();
        }

        private void price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, backspace, and control keys
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block the input
            }
        }
    }
}
