response = :greeting

case response
  when :greeting then puts "Hello!"
  when :shout then puts "Don't yell!"
  else puts "Huh?"
end
