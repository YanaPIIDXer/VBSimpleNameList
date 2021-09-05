package com.yanap.simplenamelist.model;

public class Person {
	private Long id;
	private String last_name;
	private String first_name;

	public Long getId() { return id; }
	public void setId(Long id) { this.id = id; }
	public String getLastName() { return last_name; }
	public void setLastName(String lastName) { this.last_name = lastName; }
	public String getFirstName() { return first_name; }
	public void setFirstName(String firstName) { this.first_name = firstName; }
}
