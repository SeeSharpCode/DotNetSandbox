class Employee

  def initialize(name, id)
    @name = name
    @id = id
  end

	def greet
		puts "Hi, Welcome to Ruby! My name is, #{@name}"
  end

end

t = Employee.new('John', 3)
t.greet
