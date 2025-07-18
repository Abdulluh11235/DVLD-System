﻿using Domain_Layer;
using Domain_Layer.Models.Country;

namespace Presentaion_Layer.Views.People;

public interface IAddEditPersonView
{
    BindingSource CountriesSource { set; }
    string DisplayedMemCountryList { get; set; }
    string FormText { get; set; }
    PersonModel? PersonModel { get; set; }
    string ValueMemCountryList { get; set; }

    public event EventHandler<PersonModel?> DataBack;
    event Predicate<PersonModel> PersonSavedInDB;
}