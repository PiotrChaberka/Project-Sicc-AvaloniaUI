using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace Project_SICC.Views
{
    public partial class ContractorsPageView : UserControl
    {
        private Type _currentViewType = typeof(ContractorsPageView); // Default to current view

        public ContractorsPageView()
        {
            InitializeComponent();
        }

        // Simple method to redirect to another view
        private void NavigateTo(Type viewType)
        {
            if (viewType != _currentViewType)
            {
                var instance = Activator.CreateInstance(viewType);
                if (instance is UserControl view)
                {
                    // This assumes the view is part of a navigation context (e.g., replaced in a ContentControl)
                    // In a real app, this would be handled by the parent (e.g., MainWindow) via a binding
                    var parent = this.Parent as ContentControl;
                    if (parent != null)
                    {
                        parent.Content = view;
                        _currentViewType = viewType;
                    }
                }
            }
        }

        private void OnContractorDetailsClick(object sender, RoutedEventArgs e)
        {
            NavigateTo(typeof(ContractorDetailsView));
        }

        private void OnContractsClick(object sender, RoutedEventArgs e)
        {
            NavigateTo(typeof(ContractsView));
        }

        private void OnContractsHistoryClick(object sender, RoutedEventArgs e)
        {
            NavigateTo(typeof(ContractsHistoryView));
        }

        private void OnProductsClick(object sender, RoutedEventArgs e)
        {
            NavigateTo(typeof(ProductsView));
        }
    }

    // Placeholder UserControl types (to be created as needed)
   // public class ContractsHistoryView : UserControl { }
  //  public class ProductsView : UserControl { }
}