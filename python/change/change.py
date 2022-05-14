def find_fewest_coins(coins, target):
    change = []
    coins.sort(reverse=True)
    print('coins, target=',coins, target)
    ci = 0
    while sum(coins) > target:
        if coins[ci] > target:
            del coins[ci]
        if sum(coins) < target:
            raise ValueError("can't make target with given coins")
        if coin <= target:
            change.append(coin)
            target -= coin
            change += find_fewest_coins()
        if target == 0:
            change.sort()
            return change

