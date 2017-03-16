using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Vulnerabilities.Vulnerabilities.Arbitrary_File_Reading
{
    public partial class StreamReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string res = "";
            using (FileStream fs = new FileStream(Request.Params["file"], FileMode.Open))
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(fs);
  //              while (sr.Peek() >= 0)
  //                  res += sr.ReadLine();

                sr = new System.IO.StreamReader(fs, true);
  //              while (sr.Peek() >= 0)
  //                  res += sr.ReadLine();

                sr = new System.IO.StreamReader(fs, Encoding.UTF8);
  //              while (sr.Peek() >= 0)
  //                  res += sr.ReadLine();

                sr = new System.IO.StreamReader(fs, Encoding.UTF8, true);
  //              while (sr.Peek() >= 0)
  //                  res += sr.ReadLine();

                sr = new System.IO.StreamReader(fs, Encoding.UTF8, true, 100);
  //              while (sr.Peek() >= 0)
  //                  res += sr.ReadLine();

                sr = new System.IO.StreamReader(fs, Encoding.UTF8, true, 100, false);
  //              while (sr.Peek() >= 0)
  //                  res += sr.ReadLine();
            }

            System.IO.StreamReader sr2 = new System.IO.StreamReader(Request.Params["file"]);
  //        while (sr.Peek() >= 0)
  //            res += sr.ReadLine();

            sr2 = new System.IO.StreamReader(Request.Params["file"], true);
  //        while (sr.Peek() >= 0)
  //            res += sr.ReadLine();

            sr2 = new System.IO.StreamReader(Request.Params["file"], Encoding.UTF8);
  //        while (sr.Peek() >= 0)
  //            res += sr.ReadLine();

            sr2 = new System.IO.StreamReader(Request.Params["file"], Encoding.UTF8, true);
  //        while (sr.Peek() >= 0)
  //            res += sr.ReadLine();

            sr2 = new System.IO.StreamReader(Request.Params["file"], Encoding.UTF8, true, 100);
  //        while (sr.Peek() >= 0)
  //            res += sr.ReadLine();

            Response.Write(res);

        }
    }
}