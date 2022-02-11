Imports System.Text.RegularExpressions
Public Class Form1


    'GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES 
    'GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES 
    Dim dicDishes = New SortedDictionary(Of String, SortedDictionary(Of String, SortedDictionary(Of String, Integer)))
    Dim dicPreppedItems = New SortedDictionary(Of String, SortedDictionary(Of String, Integer))
    Dim dicRawIng = New SortedDictionary(Of String, Integer)

    Sub Form1_Load(Sender As Object, e As EventArgs) Handles Me.Load
        'load dictionarys starting from bottom up
        'load raw ingredients
        dicRawIng.Add("Beef Patty", 0)
        dicRawIng.Add("Bun", 0)
        dicRawIng.Add("Ketchup", 0)
        dicRawIng.Add("Onion", 0)
        dicRawIng.Add("Potato", 0)
        dicRawIng.Add("Chicken", 0)
        dicRawIng.Add("Mayonaise", 0)
        dicRawIng.Add("Grape", 0)
        dicRawIng.Add("Plate", 0)
        dicRawIng.Add("Glass", 0)
        dicRawIng.Add("Water", 0)
        dicRawIng.Add("Basket", 0)
        dicRawIng.Add("Soft Drink Syrup", 0)
        'display keys in all raw ingredient list box
        lstAllRaw.DataSource = New BindingSource(dicRawIng, Nothing)
        lstAllRaw.DisplayMember = "Key"

        'now make some prepped items and add them to the dictionary of prepped items
        Dim dicHamburger = New SortedDictionary(Of String, Integer)
        dicHamburger.Add("Beef Patty", 0)
        dicHamburger.Add("Bun", 0)
        dicHamburger.Add("Ketchup", 0)
        dicHamburger.Add("Onion", 0)
        dicHamburger.Add("Plate", 0)
        'add the item to the dictionary of prepped items
        dicPreppedItems.Add("Hamburger", dicHamburger)

        Dim dicFries = New SortedDictionary(Of String, Integer)
        dicFries.Add("Potato", 0)
        dicFries.Add("Basket", 0)
        dicPreppedItems.Add("Fries", dicFries)

        Dim dicSoftDrink = New SortedDictionary(Of String, Integer)
        dicSoftDrink.Add("Glass", 0)
        dicSoftDrink.Add("Water", 0)
        dicSoftDrink.Add("Soft Drink Syrup", 0)
        dicPreppedItems.Add("Soft Drink", dicSoftDrink)

        Dim dicChickenSalad = New SortedDictionary(Of String, Integer)
        dicChickenSalad.Add("Chicken", 0)
        dicChickenSalad.Add("Mayonaise", 0)
        dicChickenSalad.Add("Grape", 0)
        dicChickenSalad.Add("Plate", 0)
        dicPreppedItems.Add("Chicken Salad", dicChickenSalad)

        'display the keys in the listbox of all prepped items
        lstAllPrepped.DataSource = New BindingSource(dicPreppedItems, Nothing)
        lstAllPrepped.DisplayMember = "Key"

        'now we add the dishes
        Dim dicHamburgerPlatter = New SortedDictionary(Of String, SortedDictionary(Of String, Integer))
        dicHamburgerPlatter.Add("Hamburger", dicHamburger)
        dicHamburgerPlatter.Add("Soft Drink", dicSoftDrink)
        dicHamburgerPlatter.Add("Fries", dicFries)
        dicDishes.Add("Hamburger Platter", dicHamburgerPlatter)

        Dim dicChickenSaladPlatter = New SortedDictionary(Of String, SortedDictionary(Of String, Integer))
        dicChickenSaladPlatter.Add("Chicken Salad", dicChickenSalad)
        dicChickenSaladPlatter.Add("Soft Drink", dicSoftDrink)
        dicChickenSaladPlatter.Add("Fries", dicFries)
        dicDishes.Add("Chicken Salad Platter", dicChickenSaladPlatter)

        'set listbox of all dishes to show the keys of dicDishes
        lstAllDishes.DataSource = New BindingSource(dicDishes, Nothing)
        lstAllDishes.DisplayMember = "Key"



    End Sub

    Sub Dish_Changed(sender As Object, e As EventArgs) Handles lstAllDishes.SelectedIndexChanged
        'we need to first display the prepped items in selected dish
        'we have to lookup the selected dish name in the dictionary of dishes
        Dim strDishName = lstAllDishes.SelectedItem.Key.ToString
        Dim dicSelectedItem = New SortedDictionary(Of String, SortedDictionary(Of String, Integer))
        For Each entry As KeyValuePair(Of String, SortedDictionary(Of String, SortedDictionary(Of String, Integer))) In dicDishes
            If entry.Key.ToString.Equals(strDishName) Then
                dicSelectedItem = entry.Value
            End If
        Next
        'check to see that there is a Key value pair in dicSelectedItem
        If dicSelectedItem.Count > 0 Then
            'clear listbox first
            lstItemsInSelected.Items.Clear()
            For Each entry As KeyValuePair(Of String, SortedDictionary(Of String, Integer)) In dicSelectedItem
                lstItemsInSelected.Items.Add(entry.Key)
            Next
        Else
            'here we instruct the user to add prepped items to the dish
            MessageBox.Show("Please add Prepped items to the selected dish by hitting the <- button.")
        End If

    End Sub

    Sub PreppedItem_Changed(sender As Object, e As EventArgs) Handles lstAllPrepped.SelectedIndexChanged
        'get selected item as string, not we say selectedItem.Key since since the listbox displays the key, but
        'the items attatched are still KeyValuePairs
        Dim dicSelectedItem = New SortedDictionary(Of String, Integer)
        Dim strItemName = lstAllPrepped.SelectedItem.Key.ToString

        'loop through all keyValPairs in dicPreppedItems to see which Key matches our the key of the selected
        'listbox item
        For Each entry As KeyValuePair(Of String, SortedDictionary(Of String, Integer)) In dicPreppedItems
            If entry.Key.ToString.Equals(strItemName) Then
                dicSelectedItem = entry.Value
            End If
        Next
        'check to make sure that we have raw ingredients in the selected prepped item
        If dicSelectedItem.Count > 0 Then
            'clear the listbox so we dont get a mess of raw ingredients
            lstRawInSelected.Items.Clear()
            'now we loop through the dictionary of the selected item and add the strings of the contained value
            'keyValuePairs Keys and add each key to the listbox of raw ingredients in selected item
            For Each entry As KeyValuePair(Of String, Integer) In dicSelectedItem
                lstRawInSelected.Items.Add(entry.Key)
            Next
        Else
            'tell user to add raw ingredients to prepped item
            MessageBox.Show("Please add raw ingredients to the selected prepped item.")
        End If
    End Sub

    Sub AddNewDish(sender As Object, e As EventArgs) Handles btnAddNewDish.Click
        'check to see that the dish is not already in our dictionary
        If Not dicDishes.ContainsKey(txtDish.Text) Then
            'make sure input is valid
            Dim blnValid As Boolean = validateInput(txtDish)
            If blnValid Then
                'create a dictionary to hold the selected item of from the listbox of all prepped items (lstAllPrepped)
                'and then we have to search through the dictionary of all prepped items (dicPreppedItems)
                'using the string of the key currently selected in the listbox to get an instance of
                'the dictionary we want, since the listbox is only populated as key value pair of type (String, whatever)
                '(in this instance whatever would be SortedDictionary Of String, Integer).
                Dim dicNewDishItems = New SortedDictionary(Of String, SortedDictionary(Of String, Integer))
                Dim strItemName = lstAllPrepped.SelectedItem.Key.ToString
                For Each entry As KeyValuePair(Of String, SortedDictionary(Of String, Integer)) In dicPreppedItems
                    If entry.Key.ToString.Equals(strItemName) Then
                        dicNewDishItems.Add(strItemName, entry.Value)
                    End If
                Next
                dicDishes.Add(txtDish.Text, dicNewDishItems)
                'update the listbox
                lstAllDishes.DataSource = New BindingSource(dicDishes, Nothing)
                lstAllDishes.DisplayMember = "Key"
            End If
        Else
            MessageBox.Show("Cannot add duplicate dish.")
        End If
    End Sub

    Function validateInput(txtSender As TextBox) As Boolean
        Dim blnValid As Boolean = True
        'first check that the textbox contains only alphabetical characters and is not empty
        'If a check is not met we set blnContinue to false
        If txtSender.Text.Length = 0 Then
            blnValid = False
            'set focus on the sender
            txtSender.Select()
            MessageBox.Show("Text of new item can not be empty")
        ElseIf Not Regex.IsMatch(txtSender.Text, "^[A-Za-z0-9']+$") Then
            'clear textbox
            txtSender.Text = ""
            'set focus on the sender
            txtSender.Select()
            blnValid = False
            MessageBox.Show("Text of new item can only contain letters, numbers and '")
        End If

        Return blnValid
    End Function
End Class
