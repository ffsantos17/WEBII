﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEBII
{
    public class DisciplinaViewModel
    {
        public DisciplinaVM vDisciplina { get; set; }

        public List<PreRequisitoVM>? Prerequisitos { get; set; }

        public List<SelectListItem>? vListCategoria { get; set; }

        public List<SelectListItem>? vListPreRequisito { get; set; }

    }
}
