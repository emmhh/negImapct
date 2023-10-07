with open("words_contain_age.txt", "w") as out:
    with open("words_alpha.txt", "r") as f:
        for line in f:
            if "age" in line:
                out.write(line)
                # print(line)