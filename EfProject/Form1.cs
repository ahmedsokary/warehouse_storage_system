using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////storeeeee//////////////////////////////////////////
        
        private void button2_Click(object sender, EventArgs e)//display
        {
            
            EfProjectEntities1 md = new EfProjectEntities1();
            var dispaly = from i in md.stores select i;
            dataGridView1.DataSource = dispaly.ToList();
          
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 1)
            {
                //get the id of cell choosen
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                //fill the textbox with data

                textBox1.Text = selectedRow.Cells["name"].Value.ToString();
                textBox2.Text = selectedRow.Cells["location"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Person_Incharge"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)//insert
        {
            EfProjectEntities1 md = new EfProjectEntities1();
            store st = new store();
            if(textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != "")
            {
                if(md.stores.Find(textBox1.Text)==null)
                {
                    st.name = textBox1.Text;
                    st.location = textBox2.Text;
                    st.Person_Incharge = textBox3.Text;

                    md.stores.Add(st);
                    md.SaveChanges();
                    MessageBox.Show("New store is added");
                    textBox1.Text = textBox2.Text = textBox3.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("There is an existing store with taht name");
                }
            }
            else
            {
                MessageBox.Show("Enter all data");
            }
        }

        private void Update_Click(object sender, EventArgs e)//update
        {
            EfProjectEntities1 md = new EfProjectEntities1();
            store st = md.stores.Find(textBox1.Text);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (st != null)
                {
                    st.name = textBox1.Text;
                    st.location = textBox2.Text;
                    st.Person_Incharge = textBox3.Text;

                    md.SaveChanges();
                    MessageBox.Show("store is updated");
                    textBox1.Text = textBox2.Text = textBox3.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("couldn't find the store");
                }
            }
            else
            {
                MessageBox.Show("Enter all data");
            }

        }


        /////////////////////////////////////////////supplier//////////////////////////////////////

        private void button5_Click(object sender, EventArgs e)//dispaly
        {
            EfProjectEntities1 md = new EfProjectEntities1();
            var dispaly = from i in md.suppliers select i;
            dataGridView2.DataSource = dispaly.ToList();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 1)
            {
                //get the id of cell choosen
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                //fill the textbox with data

                textBox4.Text = selectedRow.Cells["id"].Value.ToString();
                textBox5.Text = selectedRow.Cells["name"].Value.ToString();
                textBox6.Text = selectedRow.Cells["mobile"].Value.ToString();
                textBox7.Text = selectedRow.Cells["fax"].Value.ToString();
                textBox8.Text = selectedRow.Cells["mail"].Value.ToString();
                textBox9.Text = selectedRow.Cells["website"].Value.ToString();


            }
        }

        private void button3_Click(object sender, EventArgs e)//insert
        {
            EfProjectEntities1 md = new EfProjectEntities1();
            supplier st = new supplier();
            if (textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {
                if (md.suppliers.Find(int.Parse(textBox4.Text)) == null)
                {
                    st.id = int.Parse(textBox4.Text);
                    st.name = textBox5.Text;
                    st.mobile = textBox6.Text;
                    st.fax = textBox7.Text;
                    st.mail = textBox8.Text;
                    st.website = textBox9.Text;

                    md.suppliers.Add(st);
                    md.SaveChanges();
                    MessageBox.Show("New supplier is added");
                    textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("There is an existing supplier with that id");
                }
            }
            else
            {
                MessageBox.Show("Enter all data");
            }
        }

        private void button4_Click(object sender, EventArgs e)//update
        {
            EfProjectEntities1 md = new EfProjectEntities1();
            if (textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {
                supplier st = md.suppliers.Find(int.Parse(textBox4.Text));

                if (st != null)
                {
                    st.id = int.Parse(textBox4.Text);
                    st.name = textBox5.Text;
                    st.mobile = textBox6.Text;
                    st.fax = textBox7.Text;
                    st.mail = textBox8.Text;
                    st.website = textBox9.Text;

                    md.SaveChanges();
                    MessageBox.Show("supplier is updated");
                    textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("couldn't find the supplier");
                }
            }
            else
            {
                MessageBox.Show("Enter all data");
            }
        }

        /////////////////////////////customer/////////////////////////////////////
        private void button6_Click(object sender, EventArgs e)//dispaly
        {
            EfProjectEntities1 md = new EfProjectEntities1();
            var dispaly = from i in md.customers select i;
            dataGridView3.DataSource = dispaly.ToList();
        }

        private void button8_Click(object sender, EventArgs e)//insert
        {
                EfProjectEntities1 md = new EfProjectEntities1();
                customer st = new customer();
                if (textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "")
                {
                    if (md.customers.Find(int.Parse(textBox10.Text)) == null)
                    {
                        st.id = int.Parse(textBox10.Text);
                        st.name = textBox11.Text;
                        st.mobile = textBox12.Text;
                        st.fax = textBox13.Text;
                        st.mail = textBox14.Text;
                        st.website = textBox15.Text;

                        md.customers.Add(st);
                        md.SaveChanges();
                        MessageBox.Show("New customer is added");
                        textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = textBox15.Text = String.Empty;
                    }
                    else
                    {
                        MessageBox.Show("There is an existing customer with that id");
                    }
                }
                else
                {
                    MessageBox.Show("Enter all data");
                }
            

        }

        private void button7_Click(object sender, EventArgs e)//update
        {
            EfProjectEntities1 md = new EfProjectEntities1();
            if (textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "")
            {
                customer st = md.customers.Find(int.Parse(textBox10.Text));

                if (st != null)
                {
                    st.id = int.Parse(textBox10.Text);
                    st.name = textBox11.Text;
                    st.mobile = textBox12.Text;
                    st.fax = textBox13.Text;
                    st.mail = textBox14.Text;
                    st.website = textBox15.Text;

                    md.SaveChanges();
                    MessageBox.Show("customer is updated");
                    textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = textBox15.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("couldn't find the customer");
                }
            }
            else
            {
                MessageBox.Show("Enter all data");
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedCells.Count > 1)
            {
                //get the id of cell choosen
                int selectedrowindex = dataGridView3.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView3.Rows[selectedrowindex];
                //fill the textbox with data

                textBox10.Text = selectedRow.Cells["id"].Value.ToString();
                textBox11.Text = selectedRow.Cells["name"].Value.ToString();
                textBox12.Text = selectedRow.Cells["mobile"].Value.ToString();
                textBox13.Text = selectedRow.Cells["fax"].Value.ToString();
                textBox14.Text = selectedRow.Cells["mail"].Value.ToString();
                textBox15.Text = selectedRow.Cells["website"].Value.ToString();


            }
        }


        /////////////////////////////////////////////product//////////////////////////////////////

        private void button11_Click(object sender, EventArgs e)//display
        {
            EfProjectEntities1 md = new EfProjectEntities1();
            var dispaly = from i in md.products select i;
            dataGridView4.DataSource = dispaly.ToList();

        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView4.SelectedCells.Count > 1)
            {
                //get the id of cell choosen
                int selectedrowindex = dataGridView4.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView4.Rows[selectedrowindex];
                //fill the textbox with data



                textBox16.Text = selectedRow.Cells["id"].Value.ToString();
                textBox17.Text = selectedRow.Cells["name"].Value.ToString();
                //assign to the dateTimePicker1
                dateTimePicker1.Value= DateTime.Parse( selectedRow.Cells["ProdDate"].Value.ToString());
                textBox19.Text = selectedRow.Cells["ExpiryPeriod"].Value.ToString();
               


            }
        }

        private void button9_Click(object sender, EventArgs e)//insert
        {
            EfProjectEntities1 md = new EfProjectEntities1();
     
            product st = new product();
            if (textBox16.Text != "" && textBox17.Text != "" && textBox19.Text != "" )
            {
                if (md.products.Find(int.Parse(textBox16.Text)) == null)
                {
                    st.id = int.Parse(textBox16.Text);
                    st.name = textBox17.Text;
                    st.ProdDate = dateTimePicker1.Value;//use the data picker
                    st.ExpiryPeriod = int.Parse( textBox19.Text);
                    

                    md.products.Add(st);
                    md.SaveChanges();
                    MessageBox.Show("New Product is added");
                    textBox16.Text = textBox17.Text  = textBox19.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("There is an existing product with that id");
                }
            }
            else
            {
                MessageBox.Show("Enter all data");
            }
        }

        private void button10_Click(object sender, EventArgs e)//update
        {
            EfProjectEntities1 md = new EfProjectEntities1();
            if (textBox16.Text != "" && textBox17.Text != "" && textBox19.Text != "")
            {
                product st = md.products.Find(int.Parse(textBox16.Text));

                if (st != null)
                {
                    st.id = int.Parse(textBox16.Text);
                    st.name = textBox17.Text;
                    st.ProdDate = dateTimePicker1.Value;//use the data picker
                    st.ExpiryPeriod = int.Parse(textBox19.Text);


                    md.SaveChanges();
                    MessageBox.Show("product is updated");
                    textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = textBox15.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("couldn't find the product");
                }
            }
            else
            {
                MessageBox.Show("Enter all data");
            }
        }

        ///////////////////customerr Import////////////////////

        private void button14_Click(object sender, EventArgs e)//dispaly
        {
            EfProjectEntities1 md = new EfProjectEntities1();
            //1
            var dispaly = from i in md.ClientPermissions select i;
            dataGridView5.DataSource = dispaly.ToList();
            //2
            var dispaly2 = from i in md.ClientPermissionDetails select i;
            dataGridView6.DataSource = dispaly2.ToList();
        }

        /////grid1 permission
        private void dataGridView5_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedCells.Count > 1)
            {
                //get the id of cell choosen
                int selectedrowindex = dataGridView5.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView5.Rows[selectedrowindex];
                //fill the textbox with data
                textBox18.Text = selectedRow.Cells["id"].Value.ToString();
                dateTimePicker2.Value = DateTime.Parse(selectedRow.Cells["date"].Value.ToString());
                textBox21.Text = selectedRow.Cells["CId"].Value.ToString();
              

            }
        }

        //grid 2 permission details
        private void dataGridView6_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedCells.Count > 1)
            {
                if (dataGridView6.SelectedCells.Count > 1)
                {
                    //get the id of cell choosen
                    int selectedrowindex = dataGridView6.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView6.Rows[selectedrowindex];
                    //fill the textbox with data
                    textBox23.Text = selectedRow.Cells["PId"].Value.ToString();
                    textBox24.Text = selectedRow.Cells["SName"].Value.ToString();
                    textBox25.Text = selectedRow.Cells["quantity"].Value.ToString();


                }

            }
        }

        private void button12_Click_1(object sender, EventArgs e)//insert
        {
            /////client permission
          
            
            EfProjectEntities1 md = new EfProjectEntities1();

            ClientPermission st = new ClientPermission();
            ClientPermissionDetail sd = new ClientPermissionDetail();

            StoredProduct sr = new StoredProduct();


            if (textBox18.Text != "" && textBox21.Text != "" && textBox23.Text != "" && textBox24.Text != "" && textBox25.Text != "")
            {
                //can't use find as we have 2 diff sets of numbers in the ClientPermission
                int x = int.Parse(textBox18.Text);//CustomerPermId
                int y = int.Parse(textBox21.Text);//CustomerId
                int z = int.Parse(textBox23.Text);//productId
                var ClientPermId = (from d in md.ClientPermissions
                                    where d.id == x
                                    select d).FirstOrDefault();
                var CustomerId = (from d in md.customers
                                      where d.id == y
                                      select d).FirstOrDefault();
                /////client permission details////////////

                var productId = (from d in md.products
                                 where d.id == z
                                 select d).FirstOrDefault();
                var StoreName = (from d in md.stores
                                 where d.name == textBox24.Text
                                 select d).FirstOrDefault();

                ////////////checking and updating the stored product quantities

                var check = (from d in md.StoredProducts
                             where d.SName == textBox24.Text && d.PId == z
                             select d).FirstOrDefault();

                if (check == null )
                {
                    MessageBox.Show("No Product with the given store name was found");
                }
                else if(int.Parse(textBox25.Text) > check.quantity.Value)
                {
                    MessageBox.Show("The store doesn't have enought products");
                }

                else //there is store with that product and there is enough quantity
                {

                    if (ClientPermId != null)
                    {
                        MessageBox.Show("There is an existing permission with that id");
                    }
                    else if (CustomerId == null)
                    {
                        MessageBox.Show("No customer found with that id");
                    }


                    else if (productId == null)
                    {
                        MessageBox.Show("No product found with that id");
                    }
                    else if (StoreName == null)
                    {
                        MessageBox.Show("No store found with that name");
                    }
                    else
                    {
                        /////client permission

                        st.id = int.Parse(textBox18.Text);
                        st.date = dateTimePicker2.Value;//use the data picker
                        st.CId = int.Parse(textBox21.Text);


                        md.ClientPermissions.Add(st);
                        md.SaveChanges();
                        MessageBox.Show("New permission is added");


                        /////client permission details////////////
                        ///

                        sd.CPId = int.Parse(textBox18.Text);
                        sd.PId = int.Parse(textBox23.Text);
                        sd.SName = textBox24.Text;
                        sd.quantity = int.Parse(textBox25.Text);

                        md.ClientPermissionDetails.Add(sd);
                        md.SaveChanges();
                        MessageBox.Show("New permission Details is added");


                        ///update the quantity of stored product
                        check.quantity = check.quantity.Value - int.Parse(textBox25.Text);
                        md.SaveChanges();
                        MessageBox.Show("Quantity updated in stored product");

                        textBox18.Text = textBox21.Text = textBox23.Text = textBox24.Text = textBox25.Text = String.Empty;

                    }
                }

            }
            else
            {
                MessageBox.Show("Enter all data");
            }

        }



        ///////////////////////supplier permisiion//////////////////////
       

        private void button15_Click(object sender, EventArgs e)//display
        {
            EfProjectEntities1 md = new EfProjectEntities1();
            //1
            var dispaly = from i in md.SupplyPermisions select i;
            dataGridView7.DataSource = dispaly.ToList();
            //2
            var dispaly2 = from i in md.SupplyPermissionDetails select i;
            dataGridView8.DataSource = dispaly2.ToList();
        }

        //grid1
        private void dataGridView8_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView7.SelectedCells.Count > 1)
            {
                //get the id of cell choosen
                int selectedrowindex = dataGridView7.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView7.Rows[selectedrowindex];
                //fill the textbox with data
                textBox26.Text = selectedRow.Cells["id"].Value.ToString();
                dateTimePicker2.Value = DateTime.Parse(selectedRow.Cells["date"].Value.ToString());
                textBox27.Text = selectedRow.Cells["SupId"].Value.ToString();


            }
        }
        //grid2
        private void dataGridView7_SelectionChanged(object sender, EventArgs e)
        {
          
                if (dataGridView8.SelectedCells.Count > 1)
                {
                    //get the id of cell choosen
                    int selectedrowindex = dataGridView8.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView8.Rows[selectedrowindex];
                    //fill the textbox with data
                    textBox28.Text = selectedRow.Cells["PId"].Value.ToString();
                    textBox29.Text = selectedRow.Cells["SName"].Value.ToString();
                    textBox30.Text = selectedRow.Cells["quantity"].Value.ToString();


                }


        }

        private void button17_Click(object sender, EventArgs e)//insert
        {
            /////supplier permission


            EfProjectEntities1 md = new EfProjectEntities1();

            SupplyPermision st = new SupplyPermision();
            SupplyPermissionDetail sd = new SupplyPermissionDetail();

            if (textBox26.Text != "" && textBox27.Text != "" && textBox28.Text != "" && textBox29.Text != "" && textBox30.Text != "")
            {
                //can't use find as we have 2 diff sets of numbers in the ClientPermission
                int x = int.Parse(textBox26.Text);//supplierPermId
                int y = int.Parse(textBox27.Text);//supplierId

                var supplierPermId = (from d in md.SupplyPermisions
                                    where d.id == x
                                    select d).FirstOrDefault();
                var supplierId = (from d in md.suppliers
                                      where d.id == y
                                      select d).FirstOrDefault();

                /////client permission details////////////

                int z = int.Parse(textBox28.Text);//productId

                var productId = (from d in md.products
                                 where d.id == z
                                 select d).FirstOrDefault();
                var StoreName = (from d in md.stores
                                 where d.name == textBox29.Text
                                 select d).FirstOrDefault();


                if (supplierPermId != null)
                {
                    MessageBox.Show("There is an existing permission with that id");
                }
                else if (supplierId == null)
                {
                    MessageBox.Show("No customer found with that id");
                }


                else if (productId == null)
                {
                    MessageBox.Show("No product found with that id");
                }
                else if (StoreName == null)
                {
                    MessageBox.Show("No store found with that name");
                }
                else
                {
                    /////client permission

                    st.id = int.Parse(textBox26.Text);
                    st.date = dateTimePicker3.Value;//use the data picker
                    st.SupId = int.Parse(textBox27.Text);


                    md.SupplyPermisions.Add(st);
                    md.SaveChanges();
                    MessageBox.Show("New permission is added");


                    /////client permission details////////////
                    ///

                    sd.SPId = int.Parse(textBox26.Text);
                    sd.PId = int.Parse(textBox28.Text);
                    sd.SName = textBox29.Text;
                    sd.quantity = int.Parse(textBox30.Text);

                    md.SupplyPermissionDetails.Add(sd);
                    md.SaveChanges();
                    MessageBox.Show("New permission Details is added");

                    ////////////checking and updating the stored product quantities
                    ///
                    var check = (from d in md.StoredProducts
                                 where d.SName == textBox29.Text && d.PId == z
                                 select d).FirstOrDefault();
                    ///check if there is same pid and same stname with diff date as it will make a conflict
                  


                 //   MessageBox.Show(check.ProdDate.Value.Year + " " + check.ProdDate.Value.Day + " " + check.ProdDate.Value.Month);

                    StoredProduct sr = new StoredProduct();
                    /////////////////////problemm in the date comaprisson
                    if (check == null || check.ProdDate.Value.Year != dateTimePicker3.Value.Year || check.ProdDate.Value.Month != dateTimePicker3.Value.Month || check.ProdDate.Value.Day != dateTimePicker3.Value.Day)
                    {

                        if(check == null)
                        {
                            sr.SName = textBox29.Text;
                            sr.PId = int.Parse(textBox28.Text);
                            sr.quantity = int.Parse(textBox30.Text);
                            sr.ProdDate = dateTimePicker3.Value;

                            md.StoredProducts.Add(sr);
                            md.SaveChanges();
                            MessageBox.Show("New item added in stored product");
                        }
                        else
                        {
                            MessageBox.Show("There are a row with same PId and StName with Diff date");
                            MessageBox.Show("please change either of them");
                        }

                       
                    }
                    else
                    {
                        check.quantity = check.quantity.Value + int.Parse(textBox30.Text);
                        md.SaveChanges();
                        MessageBox.Show("Quantity updated in stored product");

                    }

                    textBox26.Text = textBox27.Text = textBox28.Text = textBox29.Text = textBox30.Text = String.Empty;


                }
            }
            else
            {
                MessageBox.Show("Enter all data");
            }

        }


        /////////////////////product movment/////////////////////
        private void button19_Click(object sender, EventArgs e)//diplay
        {
            EfProjectEntities1 md = new EfProjectEntities1();
            var dispaly = from i in md.StoredProducts select i;
            dataGridView9.DataSource = dispaly.ToList();
        }

        private void button18_Click(object sender, EventArgs e)//move
        {
           
            if (textBox31.Text != "" && textBox32.Text != "" && textBox33.Text != "" && textBox34.Text != "" )
            {

                EfProjectEntities1 md = new EfProjectEntities1();
                //check if from is available in the stored product 
                int x = int.Parse(textBox31.Text);//product id

                var productId = (from d in md.products//check if product exists
                                 where d.id == x
                                 select d).FirstOrDefault();
                var check = (from d in md.StoredProducts
                             where d.SName == textBox33.Text && d.PId == x
                             select d).FirstOrDefault();
                //check StoreTo is there with the same id and storName and check prodDate
                var check2 = (from d in md.StoredProducts
                              where d.SName == textBox32.Text && d.PId == x
                              select d).FirstOrDefault(); ;

                if (check == null)
                {
                    MessageBox.Show("No store with that product is found");
                }
                else if (int.Parse(textBox34.Text) > check.quantity.Value)//check quantity in the store
                {
                    MessageBox.Show("The store doesn't have enought products");
                }
                else
                {
                    //check on the storeTo 
                    //know if i will make a new storeproduct or add to an existing one
                    //existing
                    MoveProduct mp = new MoveProduct();

                    if (check2 != null && check.ProdDate.Value.Year == dateTimePicker4.Value.Year && check.ProdDate.Value.Month == dateTimePicker4.Value.Month && check.ProdDate.Value.Day == dateTimePicker4.Value.Day)
                    {
                        //add quantity of stored
                        check2.quantity = check2.quantity.Value + int.Parse(textBox34.Text);
                        //sub quantity of old stored
                        check.quantity = check.quantity.Value - int.Parse(textBox34.Text);
                        md.SaveChanges();
                        MessageBox.Show("Product is moved ");
                        MessageBox.Show("Stored product is updated ");
                        //add the moving product
                        mp.PId= int.Parse(textBox31.Text);
                        mp.StTo = textBox32.Text;
                        mp.StFrom = textBox32.Text;
                        mp.quantity= int.Parse(textBox34.Text); 
                        mp.ProdDate= dateTimePicker4.Value;
                        md.MoveProducts.Add(mp);
                        md.SaveChanges();
                        MessageBox.Show("New row added in moved product");
                    }
                    else//not existing
                    {
                        store stores = new store();
                        StoredProduct sr = new StoredProduct();
                        if (md.stores.Find(textBox32.Text) == null)
                        {
                            MessageBox.Show("No Existing store in storeTo with that name");
                        }

                        else//making new stored product
                        {

                            if (check2 == null)
                            {
                                sr.SName = textBox32.Text;
                                sr.PId = int.Parse(textBox31.Text);
                                sr.quantity = int.Parse(textBox34.Text);
                                sr.ProdDate = dateTimePicker4.Value;

                                md.StoredProducts.Add(sr);

                                //sub quantity of old stored
                                check.quantity = check.quantity.Value - int.Parse(textBox34.Text);

                                md.SaveChanges();
                                MessageBox.Show("New item added in stored product");
                                //add the moving product
                                mp.PId = int.Parse(textBox31.Text);
                                mp.StTo = textBox32.Text;
                                mp.StFrom = textBox32.Text;
                                mp.quantity = int.Parse(textBox34.Text);
                                mp.ProdDate = dateTimePicker4.Value;
                                md.MoveProducts.Add(mp);
                                md.SaveChanges();
                                MessageBox.Show("New row added in moved product");
                            }
                            else
                            {
                                MessageBox.Show("There are a row with same PId and StName with Diff date");
                                MessageBox.Show("please change either of them");
                            }


                        }

                    }
                    textBox31.Text = textBox32.Text = textBox33.Text = textBox34.Text = String.Empty;



                }
            }
            else
            {
                MessageBox.Show("Enter all data");
            }

        }

        //////Reports loads////////////////
        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }

       
    }
}
