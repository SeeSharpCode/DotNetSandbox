class Employee
puts self
  def initialize(name,id)
    @name = name
    @id = id
  end

	def greet
		puts "Hi, Welcome to Ruby! I'm #{@name}"
  end

  def self.this_is_static
    puts "This is a static method"
  end

end

Employee.this_is_static

t = Employee.new("John", 3)
t.greet

