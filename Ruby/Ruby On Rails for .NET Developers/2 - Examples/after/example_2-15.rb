class Employee

	def id
		@id
	end

	def id=(value)
		@id = value
	end

end

e = Employee.new

e.id = 10

puts e.id