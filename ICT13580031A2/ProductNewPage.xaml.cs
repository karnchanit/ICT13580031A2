using System;
using System.Collections.Generic;
using ICT13580031A2.Models;
using Xamarin.Forms;

namespace ICT13580031A2
{
    public partial class ProductNewPage : ContentPage
    {
        public ProductNewPage()
        {
            InitializeComponent();
            saveButton.Clicked += SaveButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;

			categoryPicker.Items.Add("อาหาร");
			categoryPicker.Items.Add("ตุ๊กตา");
			categoryPicker.Items.Add("เสื้อผ้า");
			categoryPicker.Items.Add("รองเท้า");

		}

        async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");

            if (isOk)
            {
                var product = new Product();
                product.Name = nameEntry.Text;
                product.Descrpition = descriptionEditor.Text;
                product.ProductPrice = decimal.Parse(productPriceEntry.Text);
                product.SellPrice = decimal.Parse(sellPriceEntry.Text);
                product.Stock = int.Parse(stockEntry.Text);
                var id = App.Dbhelper.AddProduct(product);
                await DisplayAlert("บันทึกสำเร็จ", "รหัสสินค้าของท่านคือ *" + id, "ตกลง");


            }
        }

        void CancelButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
