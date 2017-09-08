response = :greeting

if response == :greeting
  puts "Hello1!"
end

if response == :greeting then puts "Hello2!" end

puts "Hello3!" if response == :greeting

if response == :greeting
  puts "Hello4!"
elsif response == :shout
  puts "Don't yell!"
else
  puts "Huh?"
end

unless response == :greeting
  #ignore
else
  puts "Hello5!"
end

cond1 = cond3 = true
cond2 = cond4 = false

if cond1 and cond3 then puts '1' end
if cond1 and not cond3 then puts '2' end
if cond1 or cond2 then puts '3' end
if cond1 && cond3 then puts '1' end
if cond1 && !cond3 then puts '2' end
if cond1 || cond2 then puts '3' end
if (cond1 && cond3) or not (cond2 || cond4) then puts '4' end
if 'string' == 'string' then puts '5' end
if 'string' != 'string' then puts '6' end
