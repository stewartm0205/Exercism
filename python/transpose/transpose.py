def transpose(lines):
    tr_lines=[]
    l_len=len(lines)
    s_len=len(lines[0])
    for li in range(l_len):
        for si in range(s_len):
            print(li,si)
            if si == 0:
                tr_lines.append("")
                tr_lines[si] = lines[li][si]
            print(tr_lines)
            tr_lines[si] = lines[li][si]
            print(tr_lines)
        print(tr_lines)
    return tr_lines
print(transpose(["A", "1", "2"]))