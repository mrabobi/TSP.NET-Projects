using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ServiceReferencePhoto;

namespace PhotosWEB.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchCategory { get; set; }

        MyPhotosServiceClient client = new MyPhotosServiceClient();
        public List<PicTable> Pics { get; set; }



        public IndexModel()
        {
            Pics = new List<PicTable>();
        }


        public enum SearchItems
        {
            Nume,
            Categorie,
            Persoana,
            Descriere,
            Locatie
        }


        public async Task OnGetAsync()
        {
            var pics = await client.GetAllPicsForLoadAsync();
            if (!string.IsNullOrEmpty(SearchString))
            {

                pics = (await client.getDataFilteredAsync(SearchCategory, SearchString)).OrderBy(x=>x.Name_img).ToList();
            }
            else
            {
                pics = (await client.GetAllPicsForLoadAsync()).OrderBy(x =>x.Name_img).ToList();
            }

            
            
            foreach (var item in pics)
            {
                
                PicTable pic = new PicTable();
                pic.ID_IMG = item.ID_IMG;
                pic.Name_img = item.Name_img;
                pic.Description = item.Description;
                pic.Location = item.Location;
                pic.Data_create = item.Data_create;
                pic.Path = item.Path;
                pic.Person = item.Person;
                pic.Categories = item.Categories;

                Pics.Add(pic);
            }
        }

    }
}
