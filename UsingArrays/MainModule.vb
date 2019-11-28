Module MainModule

    ' When using an Array, you must specify the data type. In this example we used <As string>
    ' When using an ArrayList its collection is Untyped. Meaning you dont have to spcify what data type you want

    Sub Main()

        Main1()
        Main2()
        Main3()

        ' This function creates a dictionary called LoadProducts
        Dim products = LoadProducts()

        Console.WriteLine(products(1))
        Console.WriteLine(products(2))
        Console.WriteLine(products(3))

        ' You can use the <ContainsKey> to see if an item with a specific key exists in the dictionary
        ' It returns either true or false
        Console.WriteLine(products.ContainsKey(1))
        Console.WriteLine(products.ContainsKey(55))

        ' Display the total number of items in a dictionasry
        Console.WriteLine(products.Count)

        ' Removes an item from a list using the kwy value
        products.Remove(1)
        Console.WriteLine(products.Count)

        ' Removes All items
        products.Clear()
        Console.WriteLine(products.Count)

        Console.ReadKey()
    End Sub

    Sub Main1()
        Dim products(3) As String

        products(0) = "10 Speed Bike"
        products(1) = "Bike Helmit"
        products(2) = "Inner tube"

        Console.WriteLine(products(0))
        Console.WriteLine(products(1))
        Console.WriteLine(products(2))

        Console.WriteLine(products.Length)
    End Sub

    Sub Main2()

        ' This block of code demonstartes an ArrayList
        Dim products2 As New ArrayList From {
            "12 Speed Bike",
            "Carbon Fiber pedals",
            "Riding Gloves",
            1,
            3.35D,
            New Product With {.ProductID = 1}
        }

        Console.WriteLine(products2(0))
        Console.WriteLine(products2(1))
        Console.WriteLine(products2(2))
        Console.WriteLine(products2(3))
        Console.WriteLine(products2(4))

        Console.WriteLine(products2.Count)
    End Sub

    Sub Main3()

        Dim products As New ArrayList From {
            New Product() With {.ProductID = 1, .Name = "24 Speed Bike", .ProductNumber = "24-sp-BK"},
            New Product() With {.ProductID = 2, .Name = "Pump", .ProductNumber = "01-pump-BK"},
            New Product() With {.ProductID = 3, .Name = "Puncture Repair Kit", .ProductNumber = "03-prk-BK"}
        }

        ' DirectCast is used anytime you have an Object data type and you need to convert it to another data type
        ' ArrayLists can be annoying because they are untyped. Dictionaries are generaly better because of this.
        Console.WriteLine(DirectCast(products(0), Product).Name)
        Console.WriteLine(DirectCast(products(1), Product).Name)
        Console.WriteLine(DirectCast(products(2), Product).Name)

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
