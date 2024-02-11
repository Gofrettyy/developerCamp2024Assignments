using Business.Abstract;
using Business.KPSPublic;
using Entities.Concrete;

namespace Business.Concrete;

public class PersonManager:IApplicantService

//encapsulation 
{
    public void ApplyForMask(Person person)
    {
        
    }

    public List<Person> GetList()
    {
        return null;
    }

    public  bool CheckPerson(Person person) // gerçek bir insan mı onu kontrol edecek
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
        TCKimlikNoDogrulaRequestBody requestBody = new TCKimlikNoDogrulaRequestBody(person.NationalId, person.FirstName, person.LastName, person.DateOfBirthYear);
        TCKimlikNoDogrulaRequest request = new TCKimlikNoDogrulaRequest(requestBody);
        TCKimlikNoDogrulaResponse response = client.TCKimlikNoDogrulaAsync(request).Result;
        bool isValid = response.Body.TCKimlikNoDogrulaResult;
        return isValid;
        
    }
 }