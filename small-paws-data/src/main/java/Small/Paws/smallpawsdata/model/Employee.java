package Small.Paws.smallpawsdata.model;

import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonProperty;

import javax.persistence.*;
import java.io.Serializable;

@Table(name="Employees")
@Entity
public class Employee implements Serializable
{
  @Id
  @Column(name="User_id")
  @GeneratedValue
  private Long id;
  private String userName;
  private String password;
  private role role;
  public enum role{Veterinarian, AnimalAttendant}

  public Employee(){};

  @JsonCreator
  public Employee(@JsonProperty("id") Long id ,@JsonProperty("userName") String userName,@JsonProperty("password") String password,@JsonProperty("role") role userRole)
  {
    this.id = id;
    this.userName = userName;
    this.password = password;
    this.role = userRole;
  }

  public role getRole()
  {
    return role;
  }

  public void setRole(role role)
  {
    this.role = role;
  }

  public Long getId()
  {
    return id;
  }

  public void setId(Long id)
  {
    this.id = id;
  }

  public String getUserName()
  {
    return userName;
  }

  public void setUserName(String userName)
  {
    this.userName = userName;
  }

  public String getPassword()
  {
    return password;
  }

  public void setPassword(String password)
  {
    this.password = password;
  }
}
