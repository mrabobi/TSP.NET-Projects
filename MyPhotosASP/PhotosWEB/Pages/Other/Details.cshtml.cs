using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePhoto;

namespace PhotosWEB.Pages.Other
{
    public class DetailsModel : PageModel
    {
        MyPhotosServiceClient client = new MyPhotosServiceClient();
        public PicTable Pic { get; set; }

        public DetailsModel()
        {
            Pic = new PicTable();
        }



        public async Task OnGetAsync(int? id)
        {
            if (!id.HasValue)
                return;
            var item = (await client.GetAllPicsForLoadAsync()).OrderBy(x => x.Name_img).ToList();
            
            foreach(var pic in item)
            {
                if (pic.ID_IMG == id)
                {
                    Pic = pic; 
                }
            }

            ViewData["Post"] = Pic.Name_img.ToString();
        }
    }
}