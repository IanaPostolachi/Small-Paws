package smallpawsproject.data_access;

import smallpawsproject.model.EndUser;
import smallpawsproject.model.Animal;
import smallpawsproject.model.PetOwner;
import smallpawsproject.services.ServiceFactory;
import org.springframework.beans.factory.annotation.Autowired;

import java.util.List;

public class DataAccessImpl implements DataAccess
{
  @Autowired
  private final ServiceFactory serviceFactory;

  public DataAccessImpl(ServiceFactory serviceFactory)
  {
    this.serviceFactory = serviceFactory;
  }

  @Override public void registerPetOwner(PetOwner petOwner)
  {
    serviceFactory.getPetOwnerService().registerPetOwner(petOwner);
  }


  @Override public List<PetOwner> getPetOwners()
  {
    return serviceFactory.getPetOwnerService().getPetOwners();
  }

  @Override public List<Animal> getAnimals()
  {
    return serviceFactory.getAnimalService().getAnimals();
  }

  @Override public List<EndUser> getUsers()
  {
    return serviceFactory.getUserService().getUsers();

  }

  @Override
  public void addAnimal(Animal animal) {
    serviceFactory.getAnimalService().addAnimal(animal);
  }

  @Override
  public Animal updateAnimal(Animal animal) {
    return serviceFactory.getAnimalService().updateAnimal(animal);
  }
}
