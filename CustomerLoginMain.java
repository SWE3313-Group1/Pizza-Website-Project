
import java.util.Scanner;

public class CustomerLoginMain
{
    public static void main(String[] args)
    {

        CustomerManager manager = new CustomerManager();
        Scanner scanner = new Scanner(System.in);

        System.out.println("Login");
        System.out.print("Phone Number: ");
        String phone = scanner.nextLine();
        //System.out.println("Password");
        //String password = scanner.nextLine();


        Customer customer = manager.getCustomerByPhone(phone);

        if (customer == null)
        {
            System.out.println("No account found. Let's create a new one.");
            System.out.print("Enter your first name: ");
            String firstName = scanner.nextLine();

            System.out.print("Enter your last name: ");
            String lastName = scanner.nextLine();

            String name = firstName + " " + lastName;

            System.out.print("Enter your address: ");
            String address = scanner.nextLine();

            System.out.print("Enter your charge account type (Visa/MasterCard): ");
            String accountType = scanner.nextLine();

            //System.out.print("Enter your password: ");
            //String newPassword = scanner.nextLine();

            customer = new Customer(name, address, phone, accountType);
            manager.addCustomer(customer);

            System.out.println("Account created successfully!\n");
        }
        else
        {
            System.out.println("Welcome back, " + customer.getName() + "!");
        }

                // Simple menu loop
        boolean running = true;
        while (running) {
            System.out.println("\n--- Customer Menu ---");
            System.out.println("1. View My Info");
            System.out.println("2. Update Address");
            System.out.println("3. Exit");
            System.out.print("Choose an option (1-3): ");
            String choice = scanner.nextLine();

            switch (choice) {
                case "1":
                    System.out.println("\nYour Info:");
                    System.out.println("Name: " + customer.getName());
                    System.out.println("Address: " + customer.getAddress());
                    System.out.println("Phone: " + customer.getPhone());
                    System.out.println("Account Type: " + customer.getChargeAccountType());
                    break;
                case "2":
                    System.out.print("Enter new address: ");
                    String newAddress = scanner.nextLine();
                    customer = new Customer(customer.getName(), newAddress, customer.getPhone(), customer.getChargeAccountType());
                    manager.addCustomer(customer); // overwrite with updated info
                    System.out.println("Address updated!");
                    break;
                case "3":
                    running = false;
                    System.out.println("Goodbye!");
                    break;
                default:
                    System.out.println("Invalid choice. Try again.");
            }
        }

        scanner.close();
    }

}


