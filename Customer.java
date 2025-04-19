import org.json.JSONObject;

public class Customer
{
    private String name;
    private String address;
    private String phone;
    private String chargeAccountType;
    //private String password;

    public Customer(String name, String address, String phone, String chargeAccountType)
    {
        this.name = name;
        this.address = address;
        this.phone = phone;
        this.chargeAccountType = chargeAccountType;
        //this.password = password;
    }

    public String getName() {return name;}
    public String getAddress() {return address;}
    public String getPhone() {return phone;}
    public String getChargeAccountType() {return chargeAccountType;}
    //public String getPassword(){return password;}


    public JSONObject toJson()
    {
        JSONObject obj = new JSONObject();
        obj.put("name", name);
        obj.put("address", address);
        obj.put("phone", phone);
        obj.put("chargeAccountType", chargeAccountType);
        //obj.put("password", password);
        return obj;
    }

    public static Customer fromJson(JSONObject obj)
    {
        return new Customer
                (
                obj.getString("name"),
                obj.getString("address"),
                obj.getString("phone"),
                obj.getString("chargeAccountType")
                //obj.getString("password")
        );
    }
}

