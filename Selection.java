import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Selection
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        List<String> Order = new ArrayList<>();


        String userCrust;

        System.out.println("What crust would you like: Thin, Regular, Thick, Stuffed: ");
        userCrust = scanner.nextLine();

        switch(userCrust)
        {
            case "Thin":
                Order.add(userCrust);
                System.out.println("You have selected Thin crust.");
                break;
            case "Regular":
                Order.add(userCrust);
                System.out.println("You have selected Regular crust.");
                break;
            case "Thick":
                Order.add(userCrust);
                System.out.println("You have selected Thick crust.");
                break;
            case "Stuffed":
                Order.add(userCrust);
                System.out.println("You have selected Stuffed crust.");
            default:
                System.out.println("That option does not exist.");
                break;



        }

        String userToppings;

        System.out.println("Toppings:Pepperoni, Mushrooms, Onions, Bacon, Spinach, Tomato, Black Olives, Peppers, Pineapple, Ham, Extra Mozzarella ");
        userToppings = scanner.nextLine();

        switch(userToppings)
        {
            case "Pepperoni":
                Order.add(userToppings);
                System.out.println("You have selected Pepperoni.");
                break;
            case "Mushrooms":
                Order.add(userToppings);
                System.out.println("You have selected Mushrooms.");
                break;
            case "Onions":
                Order.add(userToppings);
                System.out.println("You have selected Onion.");
                break;
            case "Bacon":
                Order.add(userToppings);
                System.out.println("You have selected Bacon.");
            case "Spinach":
                Order.add(userToppings);
                System.out.println("You have selected Spinach.");
                break;
            case "Tomato":
                Order.add(userToppings);
                System.out.println("You have selected Tomato.");
                break;
            case "Black Olives":
                Order.add(userToppings);
                System.out.println("You have selected Black Olives.");
                break;
            case "Peppers":
                Order.add(userToppings);
                System.out.println("You have selected Peppers.");
            case "Pineapple":
                Order.add(userToppings);
                System.out.println("You have selected Pineapple.");
                break;
            case "Ham":
                Order.add(userToppings);
                System.out.println("You have selected Ham.");
                break;
            case "Extra Mozzarella":
                Order.add(userToppings);
                System.out.println("You have selected Extra Mozzarella.");
            default:
                System.out.println("That option does not exist.");
                break;



        }


        System.out.println(Order);







    }

}
