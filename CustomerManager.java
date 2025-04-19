import org.json.JSONObject;
import org.json.JSONArray;

import java.io.*;
import java.util.HashMap;
import java.util.Map;

public class CustomerManager
{
    private final String FILE_NAME = "customers.json";
    private Map<String, Customer> customerRecords = new HashMap<>();

    public CustomerManager()
    {
        loadRecords();
    }

    public void addCustomer(Customer customer)
    {
        customerRecords.put(customer.getPhone(), customer);
        saveRecords();
    }

    public Customer getCustomerByPhone(String phone)
    {
        Customer customer = customerRecords.get(phone);
        if(customer != null && customer.getPhone().equals((phone)))
        {
            return customer;
        }
        return  null;

    }

    private void loadRecords()
    {
        customerRecords.clear();
        File file = new File(FILE_NAME);
        if(!file.exists()) return;

        try(BufferedReader reader = new BufferedReader(new FileReader(file)))
        {
            StringBuilder jsonStr = new StringBuilder();
            String line;
            while((line = reader.readLine()) != null)
            {
                jsonStr.append(line);
            }
            JSONObject jsonObject = new JSONObject(jsonStr.toString());
            for (String phone : jsonObject.keySet())
            {
                JSONObject customerJson = jsonObject.getJSONObject(phone);
                Customer customer = Customer.fromJson(customerJson);
                customerRecords.put(phone, customer);
            }



        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }
    private void saveRecords()
    {
        JSONObject jsonObject = new JSONObject();
        for (String phone: customerRecords.keySet())
        {
            jsonObject.put(phone,customerRecords.get(phone).toJson());
        }
        try(BufferedWriter writer = new BufferedWriter(new FileWriter(FILE_NAME)))
        {
            writer.write(jsonObject.toString(4));
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }


}
