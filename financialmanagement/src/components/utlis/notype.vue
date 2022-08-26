<template>
    <div class="main">
        <div class="img">
            <img src="@/assets/notype.png" alt="">
            <p>对不起！您没有访问权限，请联系管理员！</p>
        </div>
        <div></div>
    </div>
</template>

<style lang="less" scoped>
    .main {
        .img {
            margin: 0 calc(50% - 350px);
            p {
                margin: 40px 0 0 40px;
                font-size: 20px;
            }
            img {
                width: 400px;
            }
            
        }
    }
</style>