package smallpawsproject.rmi;

import smallpawsproject.model.EndUser;
import smallpawsproject.model.PetOwner;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.List;

public interface Server extends Remote
{
  //  public static final String ServerTier3 = "rmi://localhost/ServerTier3";

  //  public static final String T3_SERVICE_NAME = "rmi://localhost/T3";
  void registerPetOwner(PetOwner petOwner) throws RemoteException;

  List<PetOwner> getPetOwners() throws RemoteException;
  List<EndUser> getUsers() throws RemoteException;
}
