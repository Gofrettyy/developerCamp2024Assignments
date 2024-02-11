using Business.KPSPublic;
using Entities.Concrete;

namespace Business.Abstract;

public interface IApplicantService
{
    public void ApplyForMask(Person person);


    public List<Person> GetList();


    public bool CheckPerson(Person person); // gerçek bir insan mı onu kontrol edecek

}