using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Windows;
using BBL;
using DAL;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;

namespace MyAABExample.ViewModel
{
    public class CategoryViewModel : BindableBase, INavigationAware
    {
        #region Fields and Properties
        private ObservableCollection<Item> _items;
        private ObservableCollection<Category> _categories;
        private string _btnAddUpdateCat;
        private string _btnAddUpdateItem;
        private Category _selectedCategory;

        private Item _selectedItem;
        public ICommand AddCategoryButton { get; private set; }
        public ICommand AddItemButton { get; private set; }
        
        public ObservableCollection<Category> Categories
        {
            get { return _categories; }
            set { SetProperty(ref _categories, value); }
        }
        public Category SelectedCategory
        {
            get { return this._selectedCategory; }
            set
            {
                if (_selectedCategory != value)
                {
                    SetProperty(ref _selectedCategory, value);
                }
                if (_selectedCategory.CategoryId>0)
                {
                   btnAddUpdateCat="Update Category"; 
                }else{
                    btnAddUpdateCat="Add Category";
                }
            }
        }
        public Item SelectedItem
        { 
            get { return _selectedItem; }
            set
            {
                if (_selectedItem != value)
                {
                    SetProperty(ref _selectedItem, value);

                }
                 if (_selectedItem.ItemId>0)
                {
                   btnAddUpdateItem="Update Item"; 
                }else{
                    btnAddUpdateItem="Add Item";
                }
            }
        }
        public string btnAddUpdateCat
        {
            get{return this._btnAddUpdateCat;}
            set { SetProperty(ref _btnAddUpdateCat, value); }
        }
        
        public string btnAddUpdateItem  
        {
            //this is to set the text of the add or update Item button based on if it is adding a new item or updating an item
            get { return _btnAddUpdateItem; }
            set { SetProperty(ref _btnAddUpdateItem, value); }
        }
        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }
        #endregion

        #region Constructor
        public CategoryViewModel()
        {
            _categories = CategoryService.GetAllCategories(0);
            _items = ItemService.GetAllItems(0);
            btnAddUpdateCat = "Add Category";
            btnAddUpdateItem = "Add Item";
            AddCategoryButton = new DelegateCommand(AddCategoryHandler);
            AddItemButton = new DelegateCommand(AddItemHandler);
        }
        #endregion

        #region ButtonHandlers
        public void AddCategoryHandler()
        {
            int id = CategoryService.AddUpdateCategory(SelectedCategory);
            this._categories.Add(new Category());
            this.Categories.Move(this.Categories.Count - 1, 0);
            SelectedCategory = this.Categories[0];
        }
        public void AddItemHandler()
        {
            if (SelectedItem != null)
            {
                int id = ItemService.AddUpdateItem(SelectedItem);
                Items = ItemService.GetAllItems(0);
            }
            else
            {
                MessageBox.Show("You must first add an Item!");
            }

        }
        #endregion

        #region Navigation
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            if (SelectedCategory == null)
            {
                this._categories.Add(new Category());
                this.Categories.Move(this.Categories.Count - 1, 0);
                SelectedCategory = this.Categories[0];
            }
           
        }
        #endregion
    }
}
