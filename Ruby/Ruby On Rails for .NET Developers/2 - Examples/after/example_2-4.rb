
action = :add
value = 10

result = case action

	when :add then value + value
	when :sub then value - value
	when :mul then value * value
	when :div then value / value
end

puts value