Public Class Form1

    'Declaring constants and variables

    'Size costs
    Const decPizzaSizeSmallCost As Decimal = 10
    Const decPizzaSizeMediumCost As Decimal = 13
    Const decPizzaSizeLargeCost As Decimal = 16

    'Type costs
    Const decPizzaTypePepperoniCost As Decimal = 3.5
    Const decPizzaTypeHamAndMushroomCost As Decimal = 2
    Const decPizzaTypeVegetarianCost As Decimal = 1
    Const decPizzaTypeSpecialCost As Decimal = 5

    'Extra toppings costs
    Const decExtraCheeseCost As Decimal = 2
    Const decExtraHamCost As Decimal = 2.5



    Private Sub GetTotalCost()

        'Clear UI
        lblTotal.Text = ""


        'Size selection
        Dim blnPizzaSizeSmall As Boolean = False
        Dim blnPizzaSizeMedium As Boolean = False
        Dim blnPizzaSizeLarge As Boolean = False

        'Type selection
        Dim blnPizzaTypePepperoni As Boolean = False
        Dim blnPizzaTypeHamAndMushroom As Boolean = False
        Dim blnPizzaTypeVegetarian As Boolean = False
        Dim blnPizzaTypeSpecial As Boolean = False

        'Extra toppings selection
        Dim blnExtraCheese As Boolean = False
        Dim blnExtraHam As Boolean = False

        'Quantity selection
        Dim intPizzaQuantity As Integer = 0

        'Total cost
        Dim decTotalCost As Decimal = 0

        'Handling UI interaction

        'Size selection 
        If cboPizzaSize.Text = "Small" Then
            blnPizzaSizeSmall = True
        ElseIf cboPizzaSize.Text = "Medium" Then
            blnPizzaSizeMedium = True
        ElseIf cboPizzaSize.Text = "Large" Then
            blnPizzaSizeLarge = True
        Else
            MessageBox.Show("Error: Please select a pizza size.")
            Exit Sub
        End If

        'Type selection
        If radPepperoni.Checked Then
            blnPizzaTypePepperoni = True
        ElseIf radHamAndMushroom.Checked Then
            blnPizzaTypeHamAndMushroom = True
        ElseIf radVegetarian.Checked Then
            blnPizzaTypeVegetarian = True
        ElseIf radSpecial.Checked Then
            blnPizzaTypeSpecial = True
        End If

        'Extra toppings selection
        If chkExtraCheese.Checked Then
            blnExtraCheese = True
        End If

        If chkExtraHam.Checked Then
            blnExtraHam = True
        End If

        'Quantity selection
        Select Case txtQuantity.Text
            Case 1
                intPizzaQuantity = 1
            Case 2
                intPizzaQuantity = 2
            Case 3
                intPizzaQuantity = 3
            Case 4
                intPizzaQuantity = 4
            Case 5
                intPizzaQuantity = 5
            Case 6
                intPizzaQuantity = 6
            Case 7
                intPizzaQuantity = 7
            Case 8
                intPizzaQuantity = 8
            Case 9
                intPizzaQuantity = 9
            Case 10
                intPizzaQuantity = 10
            Case Else
                MessageBox.Show("Error: Quantity must be a whole number between 1 and 10.")
                Exit Sub
        End Select

        'Cost Processing

        'Size cost
        If blnPizzaSizeSmall = True Then
            decTotalCost += decPizzaSizeSmallCost
        ElseIf blnPizzaSizeMedium = True Then
            decTotalCost += decPizzaSizeMediumCost
        ElseIf blnPizzaSizeLarge = True Then
            decTotalCost += decPizzaSizeLargeCost
        End If

        'Type cost
        If blnPizzaTypePepperoni = True Then
            decTotalCost += decPizzaTypePepperoniCost
        ElseIf blnPizzaTypeHamAndMushroom = True Then
            decTotalCost += decPizzaTypeHamAndMushroomCost
        ElseIf blnPizzaTypeVegetarian = True Then
            decTotalCost += decPizzaTypeVegetarianCost
        ElseIf blnPizzaTypeSpecial = True Then
            decTotalCost += decPizzaTypeSpecialCost
        End If

        'Extra toppings cost
        If blnExtraCheese = True Then
            decTotalCost += decExtraCheeseCost
        End If

        If blnExtraHam = True Then
            decTotalCost += decExtraHamCost
        End If

        'Quantity cost
        decTotalCost *= intPizzaQuantity



        'Getting pizza name
        Dim strPizzaSize As String = ""
        Dim strPizzaType As String = ""
        Dim strPluralGrammar As String = ""
        Dim strWithToppings As String = ""
        Dim strWithExtraCheese As String = ""
        Dim str2Toppings As String = ""
        Dim strWithExtraHam As String = ""


        'Pizza size text
        If cboPizzaSize.Text = "Small" Then
            strPizzaSize = " Small "
        ElseIf cboPizzaSize.Text = "Medium" Then
            strPizzaSize = " Medium "
        ElseIf cboPizzaSize.Text = "Large" Then
            strPizzaSize = " Large "
        End If

        'Pizza type text
        If blnPizzaTypePepperoni = True Then
            strPizzaType = "Pepperoni "
        ElseIf blnPizzaTypeHamAndMushroom = True Then
            strPizzaType = "Ham and mushroom "
        ElseIf blnPizzaTypeVegetarian = True Then
            strPizzaType = "Vegetarian "
        ElseIf blnPizzaTypeSpecial = True Then
            strPizzaType = "Special "
        End If

        'Single or multiple pizzas text
        If txtQuantity.Text = 1 Then
            strPluralGrammar = "pizza"
        Else
            strPluralGrammar = "pizzas"
        End If

        'With toppings text
        If chkExtraCheese.Checked OrElse chkExtraHam.Checked Then
            strWithToppings = " with "
        Else
            strWithToppings = ""
        End If

        'With extra cheese text
        If chkExtraCheese.Checked Then
            strWithExtraCheese = "extra cheese"
        Else
            strWithExtraCheese = ""
        End If

        'Multiple toppings text
        If chkExtraCheese.Checked AndAlso chkExtraHam.Checked Then
            str2Toppings = " and "
        Else
            str2Toppings = ""
        End If

        'With extra ham text
        If chkExtraHam.Checked Then
            strWithExtraHam = "extra ham"
        Else
            strWithExtraHam = ""
        End If


        'Display total
        lblTotal.Text = (intPizzaQuantity).ToString + (strPizzaSize) + (strPizzaType) + (strPluralGrammar) + (strWithToppings) + (strWithExtraCheese) + (str2Toppings) + (strWithExtraHam) + ". Total = " + (decTotalCost).ToString("c")



    End Sub



    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call GetTotalCost()
    End Sub


End Class
