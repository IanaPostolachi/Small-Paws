package Small.Paws.smallpawsdata.model;

import com.fasterxml.jackson.annotation.JsonCreator;

import javax.persistence.Entity;

@Entity
public class Veterinarian extends Employee
{
//  @Id
//  private Long id;
//  private String userName;
//  private String password;
//  private role role;

  @JsonCreator
  public Veterinarian(Long id,String userName, String password, role userRole)
  {
    super(id,userName,password, userRole);
  }
  public Veterinarian(){}

//  @Override public Long getId()
//  {
//    return id;
//  }
//
//  @Override public void setId(Long id)
//  {
//    this.id = id;
//  }
//
//  @Override public role getRole()
//  {
//    return role;
//  }
//
//  @Override public void setRole(role role)
//  {
//    this.role = role;
//  }
//
//  public String getUserName()
//  {
//    return userName;
//  }
//
//  public void setUserName(String userName)
//  {
//    this.userName = userName;
//  }
//
//  public String getPassword()
//  {
//    return password;
//  }
//
//  public void setPassword(String password)
//  {
//    this.password = password;
//  }
}