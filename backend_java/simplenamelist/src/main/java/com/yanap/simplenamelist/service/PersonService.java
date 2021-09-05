package com.yanap.simplenamelist.service;

import java.sql.Date;
import java.time.LocalDate;
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

	public boolean add(Person person) {
		String query = "INSERT INTO people(last_name, first_name, created_at, updated_at) VALUES(?, ?, ?, ?)";
		Date d = Date.valueOf(LocalDate.now());
		int result = jdbcTemplate.update(query, person.getlast_name(), person.getfirst_name(), d, d);
		return (result > 0);
	}

	public boolean update(Person person) {
		String query = "UPDATE people set last_name = ?, first_name = ? where id = ?;";
		int result = jdbcTemplate.update(query, person.getlast_name(), person.getfirst_name(), person.getid());
		return (result > 0);
	}

	public boolean delete(long id) {
		String query = "DELETE from people where id = ?";
		int result = jdbcTemplate.update(query, id);
		return (result > 0);
	}
}
