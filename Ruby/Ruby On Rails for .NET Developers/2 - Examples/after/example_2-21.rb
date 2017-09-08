class CustomError < StandardError
attr_reader :message, :error_id

  def initialize(message, error_id)
    @message = message
    @error_id = error_id
  end
end

begin
  raise CustomError.new("There was a problem", 1234)
rescue CustomError => ex
  puts ex.error_id
end

