class Employee

	attr_accessor :id, :name

  def method1
    self.id
  end

end

e = Employee.new

e.id = 10

puts e.method1
