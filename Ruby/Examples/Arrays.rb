# colors = Array.new
# colors = Array.new[10]

# colors.push "Yellow"
# colors << "White"
# colors[5] = "Black"

# weird_colors = ['Brown', 'Yellow']

# all_colors = colors + weird_colors

# puts all_colors.size

# puts colors[0]
# puts colors.first
# puts colors.last

# results = colors.select
# results = colors.find

colors = ['green', 'purple', 'red', 'blue', 'black', 'pink']

colorsWithE = colors.select do |c|
	c =~ /e/ # =~ checks string against regex
end

colorsWithE = colors.select { |c| c =~ /e/ } #Shorter version of the method above
colorsWithE = colors.grep(/e/) #Even better

puts colorsWithE #Outputs all colors with 'e' in the name

colors.delete('green')
colors.delete_at(2)
colors.push "magenta"

puts colors
puts colors.any? # true

# Output
# purple
# red
# black
# pink
# magenta
