begin
  x = 30 / 0
rescue ZeroDivisionError
  puts "Cannot divide by zero!"
rescue Exception => ex
  puts ex.message
ensure
  puts "This always runs."
end

class CustomError < StandardError
  attr_reader :message, :error_id

  def initialize(message, error_id)
    @message = message
    @error_id = error_id
  end
end

begin
  # raise "This is an error"
  # raise ZeroDivisionError, "This is an error"
  raise CustomError.new "There was a problem", 1234
rescue CustomError => ex
  puts ex.message
  puts ex.error_id
end
