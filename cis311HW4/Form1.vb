Imports System.Text.RegularExpressions
Public Class Form1


    'GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES 
    'GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES 
    Dim dicDishes = New SortedDictionary(Of String, SortedDictionary(Of String, SortedDictionary(Of String, Integer)))
    Dim dicPreppedItems = New SortedDictionary(Of String, SortedDictionary(Of String, Integer))
    Dim dicRawIng = New SortedDictionary(Of String, Integer)

    Sub Form1_Load(Sender As Object, e As EventArgs) Handles Me.Load
        'load dictionarys starting from bottom up
        LoadRawIng()
        LoadPreppedItemsAndDishes()
    End Sub

    Sub LoadRawIng()
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
    End Sub

    Sub LoadPreppedItemsAndDishes()
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

    Sub AddNewPreppedItem(sender As Object, e As EventArgs) Handles btnAddNewPrepped.Click
        'check that item is not in dicPrepped already
        If Not dicPreppedItems.ContainsKey(txtPrepped.Text) Then
            'make sure input is valid
            Dim blnValid As Boolean = validateInput(txtPrepped)
            If blnValid Then
                'create a diction to later populate with the text value of txtPrepped and dictionary of raw ingredients
                Dim dicNewItemIngredients = New SortedDictionary(Of String, Integer)
                Dim strIngrName = lstAllRaw.SelectedItem.Key.ToString
                For Each entry As KeyValuePair(Of String, Integer) In dicRawIng
                    If entry.Key.ToString.Equals(strIngrName) Then
                        dicNewItemIngredients.Add(strIngrName, entry.Value)
                    End If
                Next
                dicPreppedItems.Add(txtPrepped.Text, dicNewItemIngredients)
                'update the listbox
                lstAllPrepped.DataSource = New BindingSource(dicPreppedItems, Nothing)
                lstAllPrepped.DisplayMember = "Key"
            End If
        Else
            MessageBox.Show("Cannot add duplicate prepped item.")
        End If
    End Sub

    Sub AddNewRawIngredient(sender As Object, e As EventArgs) Handles btnAddNewRaw.Click
        'check that item is not in raw ingredient dictionary
        If Not dicRawIng.ContainsKey(txtRaw.Text) Then
            'check that input is valid
            Dim blnValid = validateInput(txtRaw)
            If blnValid Then
                dicRawIng.Add(txtRaw.Text, 0)
                'update the listbox
                lstAllRaw.DataSource = New BindingSource(dicRawIng, Nothing)
                lstAllRaw.DisplayMember = "Key"
            End If
        Else
            MessageBox.Show("Cannot add duplicate raw ingredient.")
        End If
    End Sub

    Sub AddPreppedToDish(sender As Object, e As EventArgs) Handles btnPreppedToSelected.Click
        'get selected item from all prepped list and dish from dish list
        Dim strItemToAdd = lstAllPrepped.SelectedItem.Key.ToString
        Dim strDish = lstAllDishes.SelectedItem.Key.ToString
        'get the dictionary of items in the dish by looping through the dish dictionary
        For Each entry As KeyValuePair(Of String, SortedDictionary(Of String, SortedDictionary(Of String, Integer))) In dicDishes
            If entry.Key.Equals(strDish) Then
                'we are on the selected dish, lets see if it contains the prepped item
                If entry.Value.ContainsKey(strItemToAdd) Then
                    'Item already in dish, display message
                    MessageBox.Show("That item is already in the selected dish.")
                Else
                    'the item is not in the dish, so we can go ahead and add it
                    Dim dicRawInItem = New SortedDictionary(Of String, SortedDictionary(Of String, Integer))
                    'we have to get the dictionary of all raw ingredients in the selected item
                    dicRawInItem = entry.Value
                    entry.Value.Add(strItemToAdd, dicRawIng)
                    'We cannot do lstItemsInselected.Update since there is no data bound to it
                    'we can change the selected index of dishes with code to update that listbox
                    If lstAllDishes.SelectedIndex - 1 < 0 Then
                        'we can not go lower so we can go higher
                        lstAllDishes.SelectedIndex = lstAllDishes.SelectedIndex + 1
                        lstAllDishes.SelectedIndex = lstAllDishes.SelectedIndex - 1
                    Else
                        'we do the same thing as in the if, just in the opposite order
                        lstAllDishes.SelectedIndex = lstAllDishes.SelectedIndex - 1
                        lstAllDishes.SelectedIndex = lstAllDishes.SelectedIndex + 1
                    End If
                End If
            End If
        Next

    End Sub

    Sub RemovePreppedItemFromDish(sender As Object, e As EventArgs) Handles btnRmvPreppedItem.Click
        'much like the add procedure we have to get a handle on the container contained within the dish dictionary
        'and then we can just use the remove function on that container to remove the prepped item
        'check that something is selected in the itemsInDish listbox
        If lstItemsInSelected.SelectedItem IsNot Nothing Then
            'Now check that there will still be items in the dish after removal
            If lstItemsInSelected.Items.Count - 1 > 0 Then
                'Note when getting the string value from lstItemsInSelected .key is not needed, since when the values were
                'added to that listbox they were added as just Strings(.key of string type)
                If dicDishes.Item(lstAllDishes.SelectedItem.Key.ToString).ContainsKey(lstItemsInSelected.SelectedItem.ToString) Then
                    'it is contained in the dictionary, so we can remove it
                    dicDishes.Item(lstAllDishes.SelectedItem.Key.ToString).Remove(lstItemsInSelected.SelectedItem.ToString)
                    'now we need to updated the selected item in the listbox with the items contained in the dish
                    If lstAllDishes.SelectedIndex - 1 < 0 Then
                        'we cannot go down an index so we can go up
                        lstAllDishes.SelectedIndex = lstAllDishes.SelectedIndex + 1
                        lstAllDishes.SelectedIndex = lstAllDishes.SelectedIndex - 1
                    Else
                        'we just have to do the same as the if block, in reverse order
                        lstAllDishes.SelectedIndex = lstAllDishes.SelectedIndex - 1
                        lstAllDishes.SelectedIndex = lstAllDishes.SelectedIndex + 1
                    End If
                End If
            Else
                MessageBox.Show("Can not remove selected item from dish since there will be no items left.")
            End If
        Else
                'no item was selected on lstItemsInSelected
                MessageBox.Show("Please select the item you wish to remove from this dish")
        End If

    End Sub

    Sub AddRawToItem(sender As Object, e As EventArgs) Handles btnRawtoPrepped.Click
        'first we have to get the prepped item as a string from lstAllPrepped and the raw ingr. from lstAllRaw
        'note we say selectedItem.Key.ToString, since the listbox is only showing the keys, but is bound to the dictionaries
        Dim strRaw = lstAllRaw.SelectedItem.Key.ToString
        Dim strItem = lstAllPrepped.SelectedItem.Key.ToString
        'now that we have the proper 'keys' we can use the same top down approach as AddPreppedToDish to get the proper
        'handles on the data containers and edit the referenced data as needed
        'we will do this by starting with dicPreppedItems and looping through the dictionary until we reach
        'the key that equals strRaw
        For Each entry As KeyValuePair(Of String, SortedDictionary(Of String, Integer)) In dicPreppedItems
            If entry.Key.Equals(strItem) Then
                'check if raw is in the contained dictionary of Raw ingredients under the current key
                If entry.Value.ContainsKey(strRaw) Then
                    MessageBox.Show("Selected raw item already in selected prepped item")
                Else
                    'we need to add the raw ingredient to the prepped item
                    entry.Value.Add(strRaw, 0)
                    'again since lstRawInSelected is not bound to any data we have to instead change the selected item
                    'of the listbox that controls the data container that loads the data into this listbox, which is lstAllPrepped
                    'again we will just change the selected item index
                    If lstAllPrepped.SelectedIndex - 1 < 0 Then
                        lstAllPrepped.SelectedIndex = lstAllPrepped.SelectedIndex + 1
                        lstAllPrepped.SelectedIndex = lstAllPrepped.SelectedIndex - 1
                    Else
                        'do the same as the above if, but reverse the order
                        lstAllPrepped.SelectedIndex = lstAllPrepped.SelectedIndex - 1
                        lstAllPrepped.SelectedIndex = lstAllPrepped.SelectedIndex + 1
                    End If
                End If
            End If
        Next
    End Sub

    Sub RemoveRawFromItem(sender As Object, e As EventArgs) Handles btnRmvRaw.Click
        'First make sure an item is selected
        If lstRawInSelected.SelectedItem IsNot Nothing Then
            'make sure that there will still be an item in lstRawInSelected
            If lstRawInSelected.Items.Count - 1 > 0 Then
                'we can remove it, double check it is in the dictionary of all prepped items
                If dicPreppedItems.Item(lstAllPrepped.SelectedItem.Key.ToString).ContainsKey(lstRawInSelected.SelectedItem.ToString) Then
                    dicPreppedItems.Item(lstAllPrepped.SelectedItem.Key.ToString).Remove(lstRawInSelected.SelectedItem.ToString)
                    'now we just have to use the same method of switching the selectedIndex to update the listBox
                    If lstAllPrepped.SelectedIndex - 1 < 0 Then
                        'we have to add first
                        lstAllPrepped.SelectedIndex = lstAllPrepped.SelectedIndex + 1
                        lstAllPrepped.SelectedIndex = lstAllPrepped.SelectedIndex - 1
                    Else
                        'we subtract first
                        lstAllPrepped.SelectedIndex = lstAllPrepped.SelectedIndex - 1
                        lstAllPrepped.SelectedIndex = lstAllPrepped.SelectedIndex + 1
                    End If
                End If
            Else
                    'tell the user that they cannot remove this ingredient
                    MessageBox.Show("Can not remove ingredient since it is the only ingredient in the item.")
            End If
        Else
            'user has to select item to remove
            MessageBox.Show("Please select the raw ingredient you would like to remove from the selected prepped item.")
        End If
    End Sub
End Class
