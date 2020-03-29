using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace SheetMaterialDataBaseApp
{
    public partial class ProductsListForm : Form
    {
        string fileName = "result.xml";
        List<Product> products;
        int id = 1;
        public ProductsListForm()
        {
            InitializeComponent();
            products = new List<Product>();
            if (File.Exists(fileName))
            {
                LoadDataFromXml();
                SetDataToDataGrid();
            }
        }

        private void SetDataToDataGrid()
        {
            foreach (var product in products)
            {
                productsGrid.Rows.Add();
                productsGrid.Rows[id - 1].Cells[0].Value = product.Id;
                productsGrid.Rows[id - 1].Cells[1].Value = product.Name;
                productsGrid.Rows[id - 1].Cells[2].Value = product.TotalCount;
                id++;
            }
        }

        private void LoadDataFromXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlElement root = doc.DocumentElement;
            foreach (XmlNode item in root.ChildNodes)
            {
                Product product = new Product();
                foreach (XmlNode node in item.ChildNodes)
                {
                    if (node.Name == "ID")
                        product.Id = int.Parse(node.InnerText);
                    if (node.Name == "ProductName")
                        product.Name = node.InnerText;
                    if (node.Name == "Count")
                        product.TotalCount = int.Parse(node.InnerText);
                }
                products.Add(product);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = id,
                Name = "Test product " + id,
                Materials = new List<Material>()
            };
            products.Add(product);
            productsGrid.Rows.Add();
            productsGrid.Rows[id - 1].Cells[0].Value = product.Id;
            productsGrid.Rows[id - 1].Cells[1].Value = product.Name;
            productsGrid.Rows[id - 1].Cells[2].Value = product.TotalCount;
            id++;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            var xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);
            var root = doc.CreateElement("ProductList");
            foreach (var item in products)
            {
                XmlElement node = doc.CreateElement("Product");
                AddChildNode("ID", item.Id.ToString(), node, doc);
                AddChildNode("ProductName", item.Name, node, doc);
                AddChildNode("Count", item.TotalCount.ToString(), node, doc);
                root.AppendChild(node);
            }
            doc.AppendChild(root);
            doc.Save(fileName);
            MessageBox.Show("Data saved");
        }
        private void AddChildNode(string childName, string childText, XmlElement parentNode, XmlDocument doc)
        {
            var child = doc.CreateElement(childName);
            child.InnerText = childText;
            parentNode.AppendChild(child);
        }

        private void ProductsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                MessageBox.Show("Button " + productsGrid[1, e.RowIndex].Value?.ToString() + " pressed");
            }
        }
    }
}
