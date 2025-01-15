Data Dictionary

Classes:
Form1 : Public class containing GetTotalCost and btnOK_Click. 

Subroutines:
GetTotalCost : handles all operations for processing inputs, calculations and display of output to lblTotal.
btnOK_Click : calls GetTotalCost when btnOK is clicked.

Controls:

cboPizzaSize : Combo box for pizza size input

radPepperoni : Radio button for selecting pizza type input
radHamAndMushroom : Radio button for selecting pizza type input
radVegetarian : Radio button for selecting pizza type input
radSpecial : Radio button for selecting pizza type input

chkExtraCheese : Check box for selecting extra cheese input
chkExtraHam : Check box for selecting extra ham input

txtQuantity : Text box for pizza quantity input

btnOK : Button, calls GetTotalCost when clicked.

lblTotal : Label for displaying order details and total cost.

Constants: 

Size costs            
decPizzaSizeSmallCost - 10
decPizzaSizeMediumCost - 13
decPizzaSizeLargeCost - 16

Type costs
decPizzaTypePepperoniCost - 3.50
decPizzaTypeHamAndMushroomCost - 2
decPizzaTypeVegetarianCost - 1
decPizzaTypeSpecialCost - 5

Extra toppings costs
decExtraCheeseCost - 2
decExtraHamCost - 2.50

Variables:

Pizza size - small  / medium / large 
blnPizzaSizeSmall
blnPizzaSizeMedium
blnPizzaSizeLarge

Pizza type - Pepperoni / Ham and Mushroom / Vegetarian / Special

blnPizzaTypePepperoni
blnPizzaTypeHamAndMushroom
blnPizzaTypeVegetarian
blnPizzaTypeSpecial


Extra toppings - extra cheese / extra ham
blnExtraCheese
blnExtraHam

Pizza quantity - 1 / 2 / 3 / 4 / 5 / 6 / 7 / 8 / 9 / 10 
intPizzaQuantity

Total cost of order - number with 2 decimal place 
decTotalCost

Pizza size string for lblTotal
strPizzaSize

Pizza type string for lblTotal
strPizzaType

String to denote singular / plural of pizza for lblTotal
strPluralGrammar

String for adding "with" if there are any extra toppings for lblTotal
strWithToppings

strWithExtraCheese
Extra cheese string for lblTotal

String for adding "and" if there are both extra toppings for lblTotal
str2Toppings

Extra ham string for lblTotal
strWithExtraHam





------------------------


Pseudocode

Processing:

Using UI:
User selects size  
User selects type
User selects toppings (optional)
User selects quantity (range 1-10)

User presses btnOK, GetTotalCost is called

Previous output of UI is cleared
Size selection, type selection, extra toppings selection and quantity selection are cleared (boolean values set to false)
Total cost is set to 0

Size, type and extra toppings input variables are checked using boolean
Quantity input variable is checked for an integer value within acceptable range
Invalid input values produce an error message and end the subroutine


Constant values are applied to cost operation based on boolean variables, multiplied by quantity integer :
(size cost + type cost + extras cost) * (quantity) = total cost


String output for lblTotal:

String values for order output are cleared
Size and type input variables are checked
Quantity is checked to determine if value is 1 or higher than 1
Whether any extra toppings have been selected is checked
Whether extra cheese has been selected is checked
Whether both extra toppings have been selected is checked
Whether extra ham has been selected is checked

A grammatically correct description of the order is created
The order description and total cost is displayed in lblTotal
