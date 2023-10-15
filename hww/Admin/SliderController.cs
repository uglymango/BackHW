using hww.DataBase.DomainModels;
using hww.DataBase;
using Microsoft.AspNetCore.Mvc;
using hww.ViewModels;
using System;
using System.Linq;

namespace hww.Admin
{
    public class SliderController : Controller
    {
        [HttpGet]
        public IActionResult Sliders()
        {
            return View(DbContext._slider);
        }

        [HttpGet]
        public IActionResult SliderAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitSlider (Slider slider)
        {
            DbContext._slider.Add(slider);

            return RedirectToAction("Sliders");
        }

        [HttpGet]
        public IActionResult SliderEdit(int id)
        {
            var slider = DbContext._slider.FirstOrDefault(p => p.Id == id);
            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }


        [HttpPost]
        public IActionResult EditSubmitSlider(SliderUpdateViewModel model)
        {
            var slider = DbContext._slider.FirstOrDefault(p => p.Id == model.Id);
            if (slider == null)
            {
                return NotFound();
            }

            slider.Title = model.Title;
            slider.Description = model.Description;
            slider.Order = model.Order;
            slider.UpdatedAt = DateTime.Now;

            return RedirectToAction("Sliders");
        }

    }
}
