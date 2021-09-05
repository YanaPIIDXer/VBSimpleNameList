package com.yanap.simplenamelist.model;

public class Person {
	private Long id;
	private String last_name;
	private String first_name;

	public Long getid() { return id; }
	public void setid(Long id) { this.id = id; }
	public String getlast_name() { return last_name; }
	public void setlast_name(String lastName) { this.last_name = lastName; }
	public String getfirst_name() { return first_name; }
	public void setfirst_name(String firstName) { this.first_name = firstName; }
	@Override
	public String toString() {
		return last_name + " " + first_name;
	}


}
