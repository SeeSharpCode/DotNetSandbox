colors = Array.new[10]

colors.push "Yellow"
colors << "White"
colors[5] = "Black"

weird_colors = ['Mauve', 'Chartreuse']

all_colors = colors + weird_colors

puts all_colors.size

puts colors[0]
puts colors.first
puts colors.last

results = colors.select
results = colors.find
