package com.yanap.simplenamelist.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.BeanPropertyRowMapper;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.stereotype.Service;

import com.yanap.simplenamelist.model.Person;

@Service
public class PersonService {

	@Autowired
	private JdbcTemplate jdbcTemplate;

	public List<Person> findAll() {
	    String query = "SELECT * from people";
	    List<Person> persons = jdbcTemplate.query(query, new BeanPropertyRowMapper<>(Person.class));
	    return persons;
	}

}
