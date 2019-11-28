Module MainModule

    Sub Main()
        ' This module will show us to use use LINQ methods

        Dim products = LoadProducts()

        ' LINQ methods iterate over a collection such as a dictionary or Array using a function and performs
        ' some kind of action. In this case we use the LoadProducts function that returns a dictionary
        ' If you can, always use LINQ queries instead of looping

        ' This quriey returns the sum of all the list prices and saves them as a currency using <ToString("c")>
        Console.WriteLine(
            products.Sum(Function(p)
                             Return p.Value.ListPrice
                         End Function).ToString("c"))

        ' Display the average of all the list prices
        ' You can use a simpler version of the LINQ function as follows to obtain the same result
        Console.WriteLine(
            products.Average(Function(p) p.Value.ListPrice).ToString("c"))

        ' Display the minimum value of all the list prices
        Console.WriteLine(
            products.Min(Function(p) p.Value.ListPrice).ToString("c"))

        Console.ReadKey()
    End Sub
    Function LoadProducts() As Dictionary(Of Integer, Product)
        Dim products As New Dictionary(Of Integer, Product)
        Dim prod As Product

        prod = New Product() With {.ProductID = 1, .Name = "500 Speed Bike", .ProductNumber = "500-sp-BK", .ListPrice = 50000.99D}
        products.Add(prod.ProductID, prod)

        prod = New Product() With {.ProductID = 2, .Name = "Turbo Charger", .ProductNumber = "Vroom Vroom mofo!", .ListPrice = 999999.99D}
        products.Add(prod.ProductID, prod)

        prod = New Product() With {.ProductID = 3, .Name = "Water Bottle", .ProductNumber = "63-lkl-BK", .ListPrice = 123.99D}
        products.Add(prod.ProductID, prod)

        Return products
    End Function

End Module
