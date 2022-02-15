Imports System.Text.RegularExpressions
Public Class Form1
    '------------------------------------------------------------------------
    '-                    File Name: Form1                                  -
    '-                    Part of Project: CIS311 HW4 (meal creating app)   -
    '------------------------------------------------------------------------
    '-                      Written By: Andrew A. Loesel                    -
    '-                      Written On: February 10, 2022                   -
    '------------------------------------------------------------------------
    '- File Purpose:                                                        -
    '-                                                                      -
    '- -
    '-                                                                      -
    '------------------------------------------------------------------------
    '- Program Purpose:                                                     -
    '-                                                                      -
    '-  -
    '------------------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):                         -
    '-         -

    'GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES 
    'GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES GLOBAL VARIABLES 
    Dim dicDishes = New SortedDictionary(Of String, SortedDictionary(Of String, SortedDictionary(Of String, Integer)))
    Dim dicPreppedItems = New SortedDictionary(Of String, SortedDictionary(Of String, Integer))
    Dim dicRawIng = New SortedDictionary(Of String, Integer)

    'SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS
    'SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS SUBPROGRAMS
    Sub Form1_Load(Sender As Object, e As EventArgs) Handles Me.Load
        '------------------------------------------------------------------------
        '-                      Subprogram Name: Form1_Load                     -
        '------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                    -
        '-                      Written On: February 10, 2022                   -
        '------------------------------------------------------------------------
        '- Subprogram Purpose:                                                  -
        '-                                                                      -
        '- The purpose of this subroutine is to call the subroutines to populate-
        '- the global dictionaries when Form1 is first loaded.                  -
        '------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                           -
        '- Sender - identifies which control used the Load event                -
        '- e - Holds the EventArgs object sent to the routine                   -
        '------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                          -
        '- None                                                                 -
        '------------------------------------------------------------------------
        'load dictionarys starting from bottom up
        LoadRawIng()
        LoadPreppedItemsAndDishes()
    End Sub

    Sub LoadRawIng()
        '------------------------------------------------------------------------
        '-                      Subprogram Name: LoadRawIng                     -
        '------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                    -
        '-                      Written On: February 10, 2022                   -
        '------------------------------------------------------------------------
        '- Subprogram Purpose:                                                  -
        '-                                                                      -
        '- The purpose of this subroutine is to load raw ingredients into the   -
        '- global sorted dictionary dicRawIng. The dictionary is then set as a  -
        '- data source for lstAllRaw so that the raw ingredients will be display-
        '- ed in that lstAllRaw.                                                -
        '------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                           -
        '- None                                                                 -
        '------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                          -
        '- None                                                                 -
        '------------------------------------------------------------------------
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
        '------------------------------------------------------------------------
        '-                      Subprogram Name: LoadPreppedItemsAndDishes      -
        '------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                    -
        '-                      Written On: February 10, 2022                   -
        '------------------------------------------------------------------------
        '- Subprogram Purpose:                                                  -
        '-                                                                      -
        '- The purpose of this subroutine is to create local dictionaries that  -
        '- will be added to the global dictionary of prepped items. The global  -
        '- prepped item dictionary, dicPreppedItems is then set to the data     -
        '- source for lstAllPrepped so that the prepped items in the dictionary -
        '- will be displayed in the list box. These dictionaries are then added -
        '- to dictionaries that represent full dishes, and these are added to   -
        '- the global dictionary of dishes, dicDishes. dicDishes is then set as -
        '- the data source for lstAllDishes so that the dishes will be displayed-
        '------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                           -
        '- None                                                                 -
        '------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                          -
        '- dicChickenSalad - a local sortedDictionary that is used to create a  -
        '-                   chicken salad. It is a prepped item.               -
        '- dicChickenSaladPlatter - a local sorted dictionary that is used to   -
        '-                        - create a chicken salad platter. It is a dish-
        '- dicFries - a sorted dictionary that is used to create prepped item   -
        '-          - fries.                                                    -
        '- dicHamburger - a sorted dictionary that is used to create a prepped  -
        '-                item Hamburger.                                       -
        '- dicHamburgerPlatter - a sorted dictionary that is used to create the -
        '-                      hamburger platter dish.                         -
        '- dicSoftDrink - a sorted dictionary that is used to create a prepped  -
        '-                item soft drink.                                      -
        '------------------------------------------------------------------------
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
        '------------------------------------------------------------------------
        '-                      Subprogram Name: ValidateInput                  -
        '------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                    -
        '-                      Written On: February 10, 2022                   -
        '------------------------------------------------------------------------
        '- Subprogram Purpose:                                                  -
        '-                                                                      -
        '- The purpose of this function is to validate the input in txtSender.  -
        '- If the txtBox's text field is not empty, and the text only has alpha -
        '- numeric data, space or ' the function returns true. Otherwise it will-
        '- return false.                                                        -
        '------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                           -
        '- txtSender - A reference to a textBox which will have its text value  -
        '-             validated.                                               -
        '------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                          -
        '- blnValid - A boolean variable that represents the validity of the ana-
        '-            lyzed text. True if valid, false if not.                  -                                                                 -
        '------------------------------------------------------------------------
        '- Returns:                                                             -
        '- blnValid - A boolean variable that represents the validity of the ana-
        '-            lyzed text. True if valid, false if not.                  -
        '------------------------------------------------------------------------
        Dim blnValid As Boolean = True
        'first check that the textbox contains only alphabetical characters and is not empty
        'If a check is not met we set blnContinue to false
        If txtSender.Text.Length = 0 Then
            blnValid = False
            'set focus on the sender
            txtSender.Select()
            MessageBox.Show("Text of new item can not be empty")
        ElseIf Not Regex.IsMatch(txtSender.Text, "^[A-Za-z0-9 ']+$") Then
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
        '------------------------------------------------------------------------
        '-                      Subprogram Name: Dish_Changed                   -
        '------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                    -
        '-                      Written On: February 10, 2022                   -
        '------------------------------------------------------------------------
        '- Subprogram Purpose:                                                  -
        '-                                                                      -
        '- The purpose of this subroutine is to display the prepped items of a  -
        '- dish when the dish is selected from lstAllDishes. The selected dish  -
        '- is found by looping through every KeyValuePair in dicAllDishes. Once -
        '- we have a reference to our selected dish we again loop through each  -
        '- KeyValuePair in the selected dish to display in order to display the -
        '- keys as strings in lstItemsInSelected.                               -
        '------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                           -
        '- Sender - identifies which control used the Load event.               -
        '- e - Holds the EventArgs object sent to the routine.                  -
        '------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                          -
        '- dicSelectedItem - A sorted dictionary that will be used as a referenc-
        '-                   e to the selected dish in lstAllDishes.            -
        '- strDishName - The name of the selected dish as a string.             -
        '------------------------------------------------------------------------
        'we need to first display the prepped items in selected dish
        'we have to lookup the selected dish name in the dictionary of dishes
        Dim strDishName = lstAllDishes.SelectedItem.Key.ToString
        Dim dicSelectedItem = New SortedDictionary(Of String, SortedDictionary(Of String, Integer))
        For Each entry As KeyValuePair(Of String, SortedDictionary(Of String, SortedDictionary(Of String, Integer))) In dicDishes
            If entry.Key.ToString.Equals(strDishName) Then
                dicSelectedItem = entry.Value
            End If
        Next
        'check to see that there is an item in dicSelectedItem
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
        '------------------------------------------------------------------------
        '-                      Subprogram Name: PreppedItem_Changed            -
        '------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                    -
        '-                      Written On: February 10, 2022                   -
        '------------------------------------------------------------------------
        '- Subprogram Purpose:                                                  -
        '-                                                                      -
        '- The purpose of this subroutine is to populate the list box for raw   -
        '- ingredients in the selected prepped item when the selected item in   -
        '- lstPreppedItems changes. First All the entries in dicPreppedITems are-
        '- looped through so that we can get a handle on the selected item. Then-
        '- The raw ingredients(as the value of the keyValuePair we get in the fi-
        '- rst for loop) are looped through and each ingredient is added to the -
        '- lstRawInSelected list box.                                           -
        '------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                           -
        '- Sender - identifies which control used the Load event.               -
        '- e - Holds the EventArgs object sent to the routine.                  -
        '------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                          -
        '- dicSelectedItem - A sorted dictionary that is used to get a handle on-
        '-                   the item selected in lstAllPrepped.                -
        '- strItemName - A string that holds the name of the selected item.     -
        '------------------------------------------------------------------------
        If Not lstAllPrepped.SelectedItems.Count = 0 Then
            'get selected item as string, now we say selectedItem.Key since since the listbox displays the key(String), but
            'the items attatched are still KeyValuePairs
            Dim dicSelectedItem = New SortedDictionary(Of String, Integer)
            'saying lstAllPrepped.SelectedItem will give us the lowest chosen item on the list (item with the lowest index)
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
        Else
            'Clear the list box for selected item raw ingredients, since no item is selected
            lstRawInSelected.Items.Clear()
        End If
    End Sub

    Sub AddNewDish(sender As Object, e As EventArgs) Handles btnAddNewDish.Click
        '------------------------------------------------------------------------
        '-                      Subprogram Name: AddNewDish                     -
        '------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                    -
        '-                      Written On: February 10, 2022                   -
        '------------------------------------------------------------------------
        '- Subprogram Purpose:                                                  -
        '-                                                                      -
        '- The purpose of this subroutine is to add a new dish to the dictionary-
        '- of dishes, and display it on the list box of dishes lstAllDishes. To -
        '- do this we first ensure that the name of the new dish is valid. We ca-
        '- ll validateInput with txtDish as a parameter to accomplish this. We  -
        '- then loop through all selected prepped items in lstAllPrepped, and ad-
        '- d each to dicNewDishItems. After the loops are done we add the new di-
        '- sh to dicDishes(the global dictionary) and update the listbox so that-
        '- the new dish is included in the items.                               -
        '------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                           -
        '- Sender - identifies which control used the Load event.               -
        '- e - Holds the EventArgs object sent to the routine.                  -
        '------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                          -
        '- blnValid - a boolean that is returned from validateInput. Is true if -
        '-            input is valid. False if not.                             -
        '- dicNewDishItems - a sorted diction that will hold all the items that -
        '-                   the user wishes to include in the new dish.        -
        '- strItemName - A string that holds the name of each selected prepped  -
        '-               item during the for each loop iteration.               -
        '------------------------------------------------------------------------

        'check to make sure that at least 1 item is selected from the prepped items
        If lstAllPrepped.SelectedItems.Count > 0 Then
            'check to see that the dish is not already in our dictionary
            If Not dicDishes.ContainsKey(txtDish.Text) Then
                'make sure input is valid
                Dim blnValid As Boolean = validateInput(txtDish)
                If blnValid Then
                    Dim dicNewDishItems = New SortedDictionary(Of String, SortedDictionary(Of String, Integer))
                    'loop through all selected items and add them
                    For i As Integer = 0 To lstAllPrepped.SelectedItems.Count - 1
                        'create a dictionary to hold the selected item of from the listbox of all prepped items (lstAllPrepped)
                        'and then we have to search through the dictionary of all prepped items (dicPreppedItems)
                        'using the string of the key currently selected in the listbox to get an instance of
                        'the dictionary we want, since the listbox is only populated as key value pair of type (String, whatever)
                        '(in this instance whatever would be SortedDictionary Of String, Integer).

                        Dim strItemName = lstAllPrepped.SelectedItems(i).Key.ToString
                        For Each entry As KeyValuePair(Of String, SortedDictionary(Of String, Integer)) In dicPreppedItems
                            If entry.Key.ToString.Equals(strItemName) Then
                                dicNewDishItems.Add(strItemName, entry.Value)
                            End If
                        Next
                    Next
                    'now add the dish
                    dicDishes.Add(txtDish.Text, dicNewDishItems)
                    'update the listbox
                    lstAllDishes.DataSource = New BindingSource(dicDishes, Nothing)
                    lstAllDishes.DisplayMember = "Key"
                End If
            Else
                MessageBox.Show("Cannot add duplicate dish.")
            End If
        Else
            MessageBox.Show("Please select at least 1 prepped item to place in dish.")
        End If
    End Sub

    Sub AddNewPreppedItem(sender As Object, e As EventArgs) Handles btnAddNewPrepped.Click
        '------------------------------------------------------------------------
        '-                      Subprogram Name: AddNewPreppedItem              -
        '------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                    -
        '-                      Written On: February 10, 2022                   -
        '------------------------------------------------------------------------
        '- Subprogram Purpose:                                                  -
        '-                                                                      -
        '- The purpose of this subroutine is to add a new prepped item to the   -
        '- global dictionary dicPreppedItems and update the listbox to show it. -
        '- First we check the input with validateInput with txtPrepped as an arg-
        '- ument. We then get a handle on all the raw ingredients the user wishe-
        '- s to have in this new item by looping through the selected items of  -
        '- lstAllRaw and adding them to the dictionary of new item ingredients. -
        '- We then use this dictionary along with the text from txtPrepped to   -
        '- add an entry in dicPreppedItems, and update the data source of lstAll-
        '- Prepped to show the new item.                                        -
        '------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                           -
        '- Sender - identifies which control used the Load event.               -
        '- e - Holds the EventArgs object sent to the routine.                  -
        '------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                          -
        '- blnValid - a boolean that is returned from validateInput. Is true if -
        '-            input is valid. False if not.                             -
        '- dicNewItemIngredients - A sorted dictionary of raw ingredients that  -
        '-                         that is populated with all the ingredients   -
        '-                         the user had selected.                       -
        '- strIngrName - A string representing the current selected ingredient  -
        '-               to be added to the new prepped item.                   -
        '------------------------------------------------------------------------
        'check that item is not in dicPrepped already
        If Not dicPreppedItems.ContainsKey(txtPrepped.Text) Then
            'make sure input is valid
            Dim blnValid As Boolean = validateInput(txtPrepped)
            If blnValid Then
                'check that at least 1 raw ingredient is selected
                If Not lstAllRaw.SelectedItems.Count = 0 Then
                    'create a dictionary to later populate with the text value of txtPrepped and dictionary of raw ingredients
                    Dim dicNewItemIngredients = New SortedDictionary(Of String, Integer)
                    'loop through all selected raw ingredients and add them to the new prepped item
                    For i As Integer = 0 To lstAllRaw.SelectedItems.Count - 1
                        Dim strIngrName = lstAllRaw.SelectedItems(i).Key.ToString
                        For Each entry As KeyValuePair(Of String, Integer) In dicRawIng
                            If entry.Key.ToString.Equals(strIngrName) Then
                                dicNewItemIngredients.Add(strIngrName, entry.Value)
                            End If
                        Next
                    Next
                    dicPreppedItems.Add(txtPrepped.Text, dicNewItemIngredients)
                    'update the listbox
                    lstAllPrepped.DataSource = New BindingSource(dicPreppedItems, Nothing)
                    lstAllPrepped.DisplayMember = "Key"
                Else
                    MessageBox.Show("Please select at least 1 raw ingredient to be in the prepped item.")
                End If
            End If
            Else
            MessageBox.Show("Cannot add duplicate prepped item.")
        End If
    End Sub

    Sub AddNewRawIngredient(sender As Object, e As EventArgs) Handles btnAddNewRaw.Click
        '------------------------------------------------------------------------
        '-                      Subprogram Name: AddNewRawIngredient            -
        '------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                    -
        '-                      Written On: February 10, 2022                   -
        '------------------------------------------------------------------------
        '- Subprogram Purpose:                                                  -
        '-                                                                      -
        '- The purpose of this subroutine is to add a new raw ingredient to the -
        '- public dictionary dicRawIng, and update lstAllRaw to display the new -
        '- ingredient along with the others. We first check that txtRaw contains-
        '- a valid ingredient name and then we just add it to the dictionary.   -
        '------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                           -
        '- Sender - identifies which control used the Load event.               -
        '- e - Holds the EventArgs object sent to the routine.                  -
        '------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                          -
        '- blnValid - a boolean that is returned from validateInput. Is true if -
        '-            input is valid. False if not.                             -
        '------------------------------------------------------------------------
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
        '------------------------------------------------------------------------
        '-                      Subprogram Name: AddPreppedToDish               -
        '------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                    -
        '-                      Written On: February 10, 2022                   -
        '------------------------------------------------------------------------
        '- Subprogram Purpose:                                                  -
        '-                                                                      -
        '- The purpose of this subroutine is to add selected prepped items to a -
        '- dish. We do this by first checking that there are selected items in  -
        '- lstAllPrepped. We Then loop through all the selected items of lstAll -
        '- Prepped and first check if it is already a prepped item in the select-
        '- ed dish, if so we display a message. If it is not already in the dish-
        '- we then get the dictionary that is nested under the selected dishes  -
        '- key, add the selected prepped item into that dictionary, and then poi-
        '- nt the dishes value to the new dictionary we created. Lastly, we chan-
        '- ge the index of lstAllDishes so that the changed item list is now sho-
        '- wn in lstPreppedInSelected.                                          -
        '------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                           -
        '- Sender - identifies which control used the Load event.               -
        '- e - Holds the EventArgs object sent to the routine.                  -
        '------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                          -
        '- dicPreppedInItem - a sorted dictionary that will hold all the prepped-
        '-                    items in the currently selected dish, prior to us -
        '-                    adding the selected items to it.                  -
        '- strDish - The string value of the dish that is getting a prepped item-
        '-           added to it.                                               -
        '- strItemToAdd - The string value of the item that we are attempting to-
        '-                add to the dish.                                      -
        '- strMsg - A formatted string message that will be shown to the user   -
        '-          when an item can not be added to the dish.                  -
        '------------------------------------------------------------------------

        'check that an item is selected
        If lstAllPrepped.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a prepped item to add to the dish.")
        Else
            Dim strDish = lstAllDishes.SelectedItem.Key.ToString
            'Add each selected item to the dish
            For i As Integer = 0 To lstAllPrepped.SelectedItems.Count - 1
                'get current item as string
                Dim strItemToAdd As String = lstAllPrepped.SelectedItems(i).Key.ToString
                'get the dictionary of items in the dish by looping through the dish dictionary
                For Each entry As KeyValuePair(Of String, SortedDictionary(Of String, SortedDictionary(Of String, Integer))) In dicDishes
                    If entry.Key.Equals(strDish) Then
                        'we are on the selected dish, lets see if it contains the prepped item
                        If entry.Value.ContainsKey(strItemToAdd) Then
                            'Item already in dish, display message
                            Dim strMsg = String.Format("'{0}' is already in the selected dish.", strItemToAdd)
                            MessageBox.Show(strMsg)
                        Else
                            'the item is not in the dish, so we can go ahead and add it
                            Dim dicPreppedInItem = New SortedDictionary(Of String, SortedDictionary(Of String, Integer))
                            'we have to get the dictionary of all raw ingredients in the selected item
                            dicPreppedInItem = entry.Value
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
            Next
        End If

    End Sub

    Sub RemovePreppedItemFromDish(sender As Object, e As EventArgs) Handles btnRmvPreppedItem.Click
        '------------------------------------------------------------------------
        '-                      Subprogram Name: RemovePreppedItemFromDish      -
        '------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                    -
        '-                      Written On: February 10, 2022                   -
        '------------------------------------------------------------------------
        '- Subprogram Purpose:                                                  -
        '-                                                                      -
        '- The purpose of this subroutine is to remove the selected items in    -
        '- lstItemsInSelected from the currently selected dish. This is done by -
        '- looping through each selected item, making sure that it is not the la-
        '- st item in the listbox. Then we get call dicDishes.Item.Remove(item) -
        '- to remove item from dish's prepped items.                            -
        '------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                           -
        '- Sender - identifies which control used the Load event.               -
        '- e - Holds the EventArgs object sent to the routine.                  -
        '------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                          -
        '- i - an integer that is the index of the for loop.                    -
        '------------------------------------------------------------------------
        'much like the add procedure we have to get a handle on the container contained within the dish dictionary
        'and then we can just use the remove function on that container to remove the prepped item
        'check that something is selected in the itemsInDish listbox
        If Not lstItemsInSelected.SelectedItems.Count = 0 Then
            'loop through all selected items
            For i As Integer = 0 To lstItemsInSelected.SelectedItems.Count - 1
                'Now check that there will still be items in the dish after removal
                If dicDishes.Item(lstAllDishes.SelectedItem.Key.ToString).Count - 1 > 0 Then
                    'Note when getting the string value from lstItemsInSelected .key is not needed, since when the values were
                    'added to that listbox they were added as just Strings(.key of string type)
                    If dicDishes.Item(lstAllDishes.SelectedItem.Key.ToString).ContainsKey(lstItemsInSelected.SelectedItems(i).ToString) Then
                        'it is contained in the dictionary, so we can remove it
                        dicDishes.Item(lstAllDishes.SelectedItem.Key.ToString).Remove(lstItemsInSelected.SelectedItems(i).ToString)
                    End If
                Else
                    MessageBox.Show("Can not remove selected item from dish since there will be no items left.")
                End If
            Next
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
        Else
            'no item was selected on lstItemsInSelected
            MessageBox.Show("Please select the item(s) you wish to remove from this dish")
        End If

    End Sub

    Sub AddRawToItem(sender As Object, e As EventArgs) Handles btnRawtoPrepped.Click
        '------------------------------------------------------------------------
        '-                      Subprogram Name: AddRawToItem                   -
        '------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                    -
        '-                      Written On: February 10, 2022                   -
        '------------------------------------------------------------------------
        '- Subprogram Purpose:                                                  -
        '-                                                                      -
        '- The prupose of this subroutine is to add selected raw ingredients    -
        '- from lstAllRaw to a selected prepped item. We loop through all the   -
        '- selected ingredients of lstAllRaw, check to see that it is not in the-
        '- selected prepped item, and then we add it to the dictionary of ingred-
        '- ients contained in the value of the selected prepped item. After all -
        '- new items are added we update the list box to display the changes.   -
        '------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                           -
        '- Sender - identifies which control used the Load event.               -
        '- e - Holds the EventArgs object sent to the routine.                  -
        '------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                          -
        '- intPreppedIndex - holds the index of the prepped item we are adding  -
        '-                   ingredients to.                                    -
        '- strItem - A string holding the name of the prepped item we are adding-
        '-           ingredients to.                                            -
        '- strMsg - A formatted string message to be displayed to the user if   -
        '-          an ingredient is already in the prepped item.               -
        '- strRaw - A string that holds the name of the raw ingredient to be    -
        '-          added to the selected item in each loop iteration.          -
        '------------------------------------------------------------------------

        'check that an ingredient is selected
        If Not lstAllRaw.SelectedItems.Count = 0 Then
            'Check that only 1 prepped item is selected
            If Not lstAllPrepped.SelectedItems.Count = 0 And lstAllPrepped.SelectedItems.Count < 2 Then
                'first we have to get the prepped item as a string from lstAllPrepped and the raw ingr. from lstAllRaw
                'note we say selectedItem.Key.ToString, since the listbox is only showing the keys, but is bound to the dictionaries
                Dim strItem = lstAllPrepped.SelectedItem.Key.ToString
                Dim intPreppedIndex As Integer = lstAllPrepped.SelectedIndex
                'now we loop through all the selected raw ingredient and add them to the prepped item
                For i As Integer = 0 To lstAllRaw.SelectedItems.Count - 1
                    'get the raw ingredient to add
                    Dim strRaw As String = lstAllRaw.SelectedItems(i).Key.ToString
                    'now that we have the proper 'keys' we can use the same top down approach as AddPreppedToDish to get the proper
                    'handles on the data containers and edit the referenced data as needed
                    'we will do this by starting with dicPreppedItems and looping through the dictionary until we reach
                    'the key that equals strRaw
                    For Each entry As KeyValuePair(Of String, SortedDictionary(Of String, Integer)) In dicPreppedItems
                        If entry.Key.Equals(strItem) Then
                            'check if raw is in the contained dictionary of Raw ingredients under the current key
                            If entry.Value.ContainsKey(strRaw) Then
                                Dim strMsg As String = String.Format("'{0}' already in selected prepped item", strRaw)
                                MessageBox.Show(strMsg)
                            Else
                                'we need to add the raw ingredient to the prepped item
                                entry.Value.Add(strRaw, 0)
                            End If
                        End If
                    Next
                Next
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
                'reset the prepped item listbox to show the item that we added ingredients to
                lstAllPrepped.SelectedIndex = intPreppedIndex
            Else
                MessageBox.Show("Please select 1 item to add ingredients to.")
            End If

        Else
                MessageBox.Show("Please select an ingredient to add to the item.")
        End If
    End Sub

    Sub RemoveRawFromItem(sender As Object, e As EventArgs) Handles btnRmvRaw.Click
        '------------------------------------------------------------------------
        '-                      Subprogram Name: RemoveRawFromItem              -
        '------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                    -
        '-                      Written On: February 10, 2022                   -
        '------------------------------------------------------------------------
        '- Subprogram Purpose:                                                  -
        '-                                                                      -
        '- The purpose of this subroutine is to remove selected raw ingredients -
        '- from the selected prepped item. We loop through the selected items in-
        '- lstRawInSelected and make sure that it is not the last ingredient in -
        '- the item. If it is not then we can just say dicPreppedItem.Item(Selec-
        '- tedItem).Remove(current item in loop iteration). After the loop is   -
        '- finished we update the index of lstAllPrepped to ensure that the user-
        '- sees the change.                                                     -
        '------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                           -
        '- Sender - identifies which control used the Load event.               -
        '- e - Holds the EventArgs object sent to the routine.                  -
        '------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                          -
        '- i - an integer used as an index in the for loop.                     -
        '------------------------------------------------------------------------
        'First make sure an item is selected
        If Not lstRawInSelected.SelectedItems.Count = 0 Then
            'loop through all selected raw items
            For i As Integer = 0 To lstRawInSelected.SelectedItems.Count - 1
                'make sure that there will still be an ingredient in the item
                If dicPreppedItems.Item(lstAllPrepped.SelectedItem.Key.ToString).Count - 1 > 0 Then
                    'we can remove it, double check it is in the dictionary of all prepped items
                    If dicPreppedItems.Item(lstAllPrepped.SelectedItem.Key.ToString).ContainsKey(lstRawInSelected.SelectedItems(i).ToString) Then
                        dicPreppedItems.Item(lstAllPrepped.SelectedItem.Key.ToString).Remove(lstRawInSelected.SelectedItems(i).ToString)

                    End If
                Else
                    'tell the user that they cannot remove this ingredient
                    MessageBox.Show("Can not remove ingredient since it is the only ingredient in the item.")
                End If
            Next
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
        Else
            'user has to select item to remove
            MessageBox.Show("Please select the raw ingredient(s) you would like to remove from the selected prepped item.")
        End If
    End Sub
End Class
