// This file was automatically generated by the Dapper.SimpleCRUD T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `EpDB`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=DESKTOP-KH51Q3A;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False`
//     Include Views:          `True`

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace EP.DAL.Models
{
    /// <summary>
    /// A class which represents the Employees table.
    /// </summary>
	[Table("Employees")]
	public partial class Employee
	{
		[Key]
		public virtual int EmployeeID { get; set; }
		public virtual string LastName { get; set; }
		public virtual string FirstName { get; set; }
		public virtual string Title { get; set; }
		public virtual string TitleOfCourtesy { get; set; }
		public virtual DateTime? BirthDate { get; set; }
		public virtual DateTime? HireDate { get; set; }
		public virtual string Address { get; set; }
		public virtual string City { get; set; }
		public virtual string Region { get; set; }
		public virtual string PostalCode { get; set; }
		public virtual string Country { get; set; }
		public virtual string HomePhone { get; set; }
		public virtual string Extension { get; set; }
		public virtual byte[] Photo { get; set; }
		public virtual string Notes { get; set; }
		public virtual int? ReportsTo { get; set; }
		public virtual string PhotoPath { get; set; }
		public virtual Employee Employeee { get; set; }
		public virtual IEnumerable<Employee> Employees { get; set; }
		public virtual IEnumerable<Order> Orders { get; set; }
		public virtual IEnumerable<EmployeeTerritory> EmployeeTerritories { get; set; }
	}

    /// <summary>
    /// A class which represents the Categories table.
    /// </summary>
	[Table("Categories")]
	public partial class Category
	{
		[Key]
		public virtual int CategoryID { get; set; }
		public virtual string CategoryName { get; set; }
		public virtual string Description { get; set; }
		public virtual byte[] Picture { get; set; }
		public virtual IEnumerable<Product> Products { get; set; }
	}

    /// <summary>
    /// A class which represents the Customers table.
    /// </summary>
	[Table("Customers")]
	public partial class Customer
	{
		[Key]
		public virtual string CustomerID { get; set; }
		public virtual string CompanyName { get; set; }
		public virtual string ContactName { get; set; }
		public virtual string ContactTitle { get; set; }
		public virtual string Address { get; set; }
		public virtual string City { get; set; }
		public virtual string Region { get; set; }
		public virtual string PostalCode { get; set; }
		public virtual string Country { get; set; }
		public virtual string Phone { get; set; }
		public virtual string Fax { get; set; }
		public virtual IEnumerable<Order> Orders { get; set; }
		public virtual IEnumerable<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }
	}

    /// <summary>
    /// A class which represents the Shippers table.
    /// </summary>
	[Table("Shippers")]
	public partial class Shipper
	{
		[Key]
		public virtual int ShipperID { get; set; }
		public virtual string CompanyName { get; set; }
		public virtual string Phone { get; set; }
		public virtual IEnumerable<Order> Orders { get; set; }
	}

    /// <summary>
    /// A class which represents the Suppliers table.
    /// </summary>
	[Table("Suppliers")]
	public partial class Supplier
	{
		[Key]
		public virtual int SupplierID { get; set; }
		public virtual string CompanyName { get; set; }
		public virtual string ContactName { get; set; }
		public virtual string ContactTitle { get; set; }
		public virtual string Address { get; set; }
		public virtual string City { get; set; }
		public virtual string Region { get; set; }
		public virtual string PostalCode { get; set; }
		public virtual string Country { get; set; }
		public virtual string Phone { get; set; }
		public virtual string Fax { get; set; }
		public virtual string HomePage { get; set; }
		public virtual IEnumerable<Product> Products { get; set; }
	}

    /// <summary>
    /// A class which represents the Orders table.
    /// </summary>
	[Table("Orders")]
	public partial class Order
	{
		[Key]
		public virtual int OrderID { get; set; }
		public virtual string CustomerID { get; set; }
		public virtual int? EmployeeID { get; set; }
		public virtual DateTime? OrderDate { get; set; }
		public virtual DateTime? RequiredDate { get; set; }
		public virtual DateTime? ShippedDate { get; set; }
		public virtual int? ShipVia { get; set; }
		public virtual decimal? Freight { get; set; }
		public virtual string ShipName { get; set; }
		public virtual string ShipAddress { get; set; }
		public virtual string ShipCity { get; set; }
		public virtual string ShipRegion { get; set; }
		public virtual string ShipPostalCode { get; set; }
		public virtual string ShipCountry { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual Employee Employee { get; set; }
		public virtual Shipper Shipper { get; set; }
		public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
	}

    /// <summary>
    /// A class which represents the Products table.
    /// </summary>
	[Table("Products")]
	public partial class Product
	{
		[Key]
		public virtual int ProductID { get; set; }
		public virtual string ProductName { get; set; }
		public virtual int? SupplierID { get; set; }
		public virtual int? CategoryID { get; set; }
		public virtual string QuantityPerUnit { get; set; }
		public virtual decimal? UnitPrice { get; set; }
		public virtual short? UnitsInStock { get; set; }
		public virtual short? UnitsOnOrder { get; set; }
		public virtual short? ReorderLevel { get; set; }
		public virtual bool Discontinued { get; set; }
		public virtual Supplier Supplier { get; set; }
		public virtual Category Category { get; set; }
		public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
	}

    /// <summary>
    /// A class which represents the Order Details table.
    /// </summary>
	[Table("Order Details")]
	public partial class OrderDetail
	{
		[Key]
		public virtual int OrderID { get; set; }
		public virtual int ProductID { get; set; }
		public virtual decimal UnitPrice { get; set; }
		public virtual short Quantity { get; set; }
		public virtual float Discount { get; set; }
		public virtual Order Order { get; set; }
		public virtual Product Product { get; set; }
	}

    /// <summary>
    /// A class which represents the Customer and Suppliers by City view.
    /// </summary>
	[Table("Customer and Suppliers by City")]
	public partial class CustomerandSuppliersbyCity
	{
		public virtual string City { get; set; }
		public virtual string CompanyName { get; set; }
		public virtual string ContactName { get; set; }
		public virtual string Relationship { get; set; }
	}

    /// <summary>
    /// A class which represents the Alphabetical list of products view.
    /// </summary>
	[Table("Alphabetical list of products")]
	public partial class Alphabeticallistofproduct
	{
		public virtual int ProductID { get; set; }
		public virtual string ProductName { get; set; }
		public virtual int? SupplierID { get; set; }
		public virtual int? CategoryID { get; set; }
		public virtual string QuantityPerUnit { get; set; }
		public virtual decimal? UnitPrice { get; set; }
		public virtual short? UnitsInStock { get; set; }
		public virtual short? UnitsOnOrder { get; set; }
		public virtual short? ReorderLevel { get; set; }
		public virtual bool Discontinued { get; set; }
		public virtual string CategoryName { get; set; }
	}

    /// <summary>
    /// A class which represents the Current Product List view.
    /// </summary>
	[Table("Current Product List")]
	public partial class CurrentProductList
	{
		public virtual int ProductID { get; set; }
		public virtual string ProductName { get; set; }
	}

    /// <summary>
    /// A class which represents the Orders Qry view.
    /// </summary>
	[Table("Orders Qry")]
	public partial class OrdersQry
	{
		public virtual int OrderID { get; set; }
		public virtual string CustomerID { get; set; }
		public virtual int? EmployeeID { get; set; }
		public virtual DateTime? OrderDate { get; set; }
		public virtual DateTime? RequiredDate { get; set; }
		public virtual DateTime? ShippedDate { get; set; }
		public virtual int? ShipVia { get; set; }
		public virtual decimal? Freight { get; set; }
		public virtual string ShipName { get; set; }
		public virtual string ShipAddress { get; set; }
		public virtual string ShipCity { get; set; }
		public virtual string ShipRegion { get; set; }
		public virtual string ShipPostalCode { get; set; }
		public virtual string ShipCountry { get; set; }
		public virtual string CompanyName { get; set; }
		public virtual string Address { get; set; }
		public virtual string City { get; set; }
		public virtual string Region { get; set; }
		public virtual string PostalCode { get; set; }
		public virtual string Country { get; set; }
	}

    /// <summary>
    /// A class which represents the Products Above Average Price view.
    /// </summary>
	[Table("Products Above Average Price")]
	public partial class ProductsAboveAveragePrice
	{
		public virtual string ProductName { get; set; }
		public virtual decimal? UnitPrice { get; set; }
	}

    /// <summary>
    /// A class which represents the Products by Category view.
    /// </summary>
	[Table("Products by Category")]
	public partial class ProductsbyCategory
	{
		public virtual string CategoryName { get; set; }
		public virtual string ProductName { get; set; }
		public virtual string QuantityPerUnit { get; set; }
		public virtual short? UnitsInStock { get; set; }
		public virtual bool Discontinued { get; set; }
	}

    /// <summary>
    /// A class which represents the Quarterly Orders view.
    /// </summary>
	[Table("Quarterly Orders")]
	public partial class QuarterlyOrder
	{
		public virtual string CustomerID { get; set; }
		public virtual string CompanyName { get; set; }
		public virtual string City { get; set; }
		public virtual string Country { get; set; }
	}

    /// <summary>
    /// A class which represents the Invoices view.
    /// </summary>
	[Table("Invoices")]
	public partial class Invoice
	{
		public virtual string ShipName { get; set; }
		public virtual string ShipAddress { get; set; }
		public virtual string ShipCity { get; set; }
		public virtual string ShipRegion { get; set; }
		public virtual string ShipPostalCode { get; set; }
		public virtual string ShipCountry { get; set; }
		public virtual string CustomerID { get; set; }
		public virtual string CustomerName { get; set; }
		public virtual string Address { get; set; }
		public virtual string City { get; set; }
		public virtual string Region { get; set; }
		public virtual string PostalCode { get; set; }
		public virtual string Country { get; set; }
		public virtual string Salesperson { get; set; }
		public virtual int OrderID { get; set; }
		public virtual DateTime? OrderDate { get; set; }
		public virtual DateTime? RequiredDate { get; set; }
		public virtual DateTime? ShippedDate { get; set; }
		public virtual string ShipperName { get; set; }
		public virtual int ProductID { get; set; }
		public virtual string ProductName { get; set; }
		public virtual decimal UnitPrice { get; set; }
		public virtual short Quantity { get; set; }
		public virtual float Discount { get; set; }
		public virtual decimal? ExtendedPrice { get; set; }
		public virtual decimal? Freight { get; set; }
	}

    /// <summary>
    /// A class which represents the Order Details Extended view.
    /// </summary>
	[Table("Order Details Extended")]
	public partial class OrderDetailsExtended
	{
		public virtual int OrderID { get; set; }
		public virtual int ProductID { get; set; }
		public virtual string ProductName { get; set; }
		public virtual decimal UnitPrice { get; set; }
		public virtual short Quantity { get; set; }
		public virtual float Discount { get; set; }
		public virtual decimal? ExtendedPrice { get; set; }
	}

    /// <summary>
    /// A class which represents the Order Subtotals view.
    /// </summary>
	[Table("Order Subtotals")]
	public partial class OrderSubtotal
	{
		public virtual int OrderID { get; set; }
		public virtual decimal? Subtotal { get; set; }
	}

    /// <summary>
    /// A class which represents the Product Sales for 1997 view.
    /// </summary>
	[Table("Product Sales for 1997")]
	public partial class ProductSalesfor1997
	{
		public virtual string CategoryName { get; set; }
		public virtual string ProductName { get; set; }
		public virtual decimal? ProductSales { get; set; }
	}

    /// <summary>
    /// A class which represents the Category Sales for 1997 view.
    /// </summary>
	[Table("Category Sales for 1997")]
	public partial class CategorySalesfor1997
	{
		public virtual string CategoryName { get; set; }
		public virtual decimal? CategorySales { get; set; }
	}

    /// <summary>
    /// A class which represents the Sales by Category view.
    /// </summary>
	[Table("Sales by Category")]
	public partial class SalesbyCategory
	{
		public virtual int CategoryID { get; set; }
		public virtual string CategoryName { get; set; }
		public virtual string ProductName { get; set; }
		public virtual decimal? ProductSales { get; set; }
	}

    /// <summary>
    /// A class which represents the Sales Totals by Amount view.
    /// </summary>
	[Table("Sales Totals by Amount")]
	public partial class SalesTotalsbyAmount
	{
		public virtual decimal? SaleAmount { get; set; }
		public virtual int OrderID { get; set; }
		public virtual string CompanyName { get; set; }
		public virtual DateTime? ShippedDate { get; set; }
	}

    /// <summary>
    /// A class which represents the Summary of Sales by Quarter view.
    /// </summary>
	[Table("Summary of Sales by Quarter")]
	public partial class SummaryofSalesbyQuarter
	{
		public virtual DateTime? ShippedDate { get; set; }
		public virtual int OrderID { get; set; }
		public virtual decimal? Subtotal { get; set; }
	}

    /// <summary>
    /// A class which represents the Summary of Sales by Year view.
    /// </summary>
	[Table("Summary of Sales by Year")]
	public partial class SummaryofSalesbyYear
	{
		public virtual DateTime? ShippedDate { get; set; }
		public virtual int OrderID { get; set; }
		public virtual decimal? Subtotal { get; set; }
	}

    /// <summary>
    /// A class which represents the CustomerCustomerDemo table.
    /// </summary>
	[Table("CustomerCustomerDemo")]
	public partial class CustomerCustomerDemo
	{
		public virtual string CustomerID { get; set; }
		public virtual string CustomerTypeID { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual CustomerDemographic CustomerDemographic { get; set; }
	}

    /// <summary>
    /// A class which represents the CustomerDemographics table.
    /// </summary>
	[Table("CustomerDemographics")]
	public partial class CustomerDemographic
	{
		public virtual string CustomerTypeID { get; set; }
		public virtual string CustomerDesc { get; set; }
		public virtual IEnumerable<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }
	}

    /// <summary>
    /// A class which represents the Region table.
    /// </summary>
	[Table("Region")]
	public partial class Region
	{
		public virtual int RegionID { get; set; }
		public virtual string RegionDescription { get; set; }
		public virtual IEnumerable<Territory> Territories { get; set; }
	}

    /// <summary>
    /// A class which represents the Territories table.
    /// </summary>
	[Table("Territories")]
	public partial class Territory
	{
		public virtual string TerritoryID { get; set; }
		public virtual string TerritoryDescription { get; set; }
		public virtual int RegionID { get; set; }
		public virtual Region Region { get; set; }
		public virtual IEnumerable<EmployeeTerritory> EmployeeTerritories { get; set; }
	}

    /// <summary>
    /// A class which represents the EmployeeTerritories table.
    /// </summary>
	[Table("EmployeeTerritories")]
	public partial class EmployeeTerritory
	{
		public virtual int EmployeeID { get; set; }
		public virtual string TerritoryID { get; set; }
		public virtual Employee Employee { get; set; }
		public virtual Territory Territory { get; set; }
	}

}
