
namespace MyFinancePlanner
{
    internal class MonEx // Monthly Expenses
    {
        internal short Tag { get; set; } // 0 = Bills | 1 = Savings
        internal string Name { get; set; } = "unknown"; // default value
        internal decimal Value { get; set; }


    }

    /*
    Things that in need To Do for the Fixed Costs:

    Fixed Costs suppose to be in two catigories, Bills and Saveings

    Savings come into the Bank/Stock Market
    And bills are bills. Rent, Internet, Spotify etc.

    Lets start from the beginning:

    If we start the Program, we need to load the fixed costs from a spesific file. 
    There should be an spesific file for the fixed costs because most of the time they are the same. So make the into an extra file.
    So we load the fixed costs from a JSON file or something like that.
    If we can find any fixed costs data or cant load it, the user needs to creat one on its owne.
    We should gave out a message "Couldnt find any data for fixed Costs or there is something worng with it" or something like that. 
    We open a window so the user can deffine his monthly costs (again).
    This data should be saved instandly in the project folder or in Documents or something like that. I'm not shure where i should save that.
    There should be an spesific folder for this data because if there is an new one created, delete the files in this folder and save a new file.
    This have the effect we just need to search for one file and not the latest and we have no struggle if we load the wrong data.
    This delete and save process should be started after the user clickt on the "SAVE" -button in the "Creat new fixed costs" Window.
    The fixed costs are also saved in the monthly report so the user can still look at them even we delete the old fixed costs file.

    We have two points left. 1. The design for the fixed costs Window and 2. How do i handle the Data

    2.
    I made some brainstorming for the data. 
    I could save them as object but this is maybe to much. 
    I could save them as consts but there is a lot of handling if there is any changes.
    Maybe i can handle them as one object with diffrent values?
    I ask ChatGPT and it said, i should use a class and a List or an dictionary to manage my data.
    I think i take the class with List plan. This made my Interface useless i think.
    I make a class with a Tag Value (bill or saving), a Value and a Name. Some functions and make it serializible.
    The Creat funtkion should make a new object and add them to the list. So i just have to serialize the list.
    If i need to change a Value, i call the list and change it by the Name or the selection. Maybe both.


    1.
    I thought about a new window with two Listviews. Maybe there is one textbox where the user can define a new one, so i dont need two "add" buttons.
    Or maybe better, i have one listview and the Items in the listview have different background colors refferenced to its tag. Savings are gold and bills are red.
    This is better because i need just one add and delete button. And i can sort it by Tag or Value. 
    I also should add a change button based on selection. The question is now, should is open a new window for this or should i chage the Value in the Listview by its selektion.
    If i change the value in the Listview, i think there is more that can go wrong.
    It is cool to change the items in an exrta view because you also can change the Tag. But, this makes no sense in real life. I should go with the Listview change

    The fixed costs View should appear if something ist wrong with the data and by a button in the Main Menu.
    It should be alwayse on top, and have a Save and abort Button. The user can click the Change Button if he did a selektion in the listview. The selekted Item can be changend.
    If the User press the Save-Button, the olf file in the fixed costs folder should be deleted. After this, create the new one

    Done
    */


}
