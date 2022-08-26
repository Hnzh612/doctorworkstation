<template>
<div v-if="this.$type == '管理员'">
  <el-table :data="tableData" border style="width: 90%">
    <el-table-column fixed prop="number" label="编号" width="150">
    </el-table-column>
    <el-table-column prop="name" label="姓名" width="120"> </el-table-column>
    <el-table-column prop="illness" label="病情" width="120"> </el-table-column>
    <el-table-column prop="sex" label="性别" width="120"> </el-table-column>
    <el-table-column prop="address" label="地址" width="300"> </el-table-column>
    <el-table-column
      prop="tag"
      label="权限"
      width="100"
      :filters="[
        { text: '允许', value: '允许' },
        { text: '禁止', value: '禁止' },
      ]"
      :filter-method="filterTag"
      filter-placement="bottom-end"
    >
      <template slot-scope="scope">
        <el-tag
          :type="scope.row.tag === '禁止' ? 'primary' : 'success'"
          disable-transitions
          >{{ scope.row.tag }}</el-tag
        >
      </template>
    </el-table-column>
    <el-table-column fixed="right" label="操作" align="center">
      <template slot-scope="scope">
        <el-button @click="handleClick(scope.row)" type="text" size="small"
          >查看</el-button
        >
        <el-button type="text" size="small">编辑</el-button>
      </template>
    </el-table-column>
  </el-table>
</div>
<notype v-else></notype>

</template>

<script>
import notype from '@/components/utlis/notype.vue'
export default {
  components:{ notype },
  methods: {
    handleClick(row) {
      console.log(row);
    },
  },

  data() {
    return {
      tableData: [
        {
          number: "0001",
          name: "王小虎",
          illness: "严重",
          sex: "男",
          address: "上海市普陀区金沙江路 1518 弄",
          tag: "允许",
        },
        {
          number: "0002",
          name: "李牛牛",
          illness: "中度",
          sex: "男",
          address: "上海市普陀区金沙江路 1517 弄",
          tag: "禁止",
        },
        {
          number: "0003",
          name: "张梅梅",
          illness: "轻微",
          sex: "女",
          address: "上海市普陀区金沙江路 1519 弄",
          tag: "允许",
        },
        {
          number: "0004",
          name: "赵小美",
          illness: "中度",
          sex: "女",
          address: "上海市普陀区金沙江路 1516 弄",
          tag: "禁止",
        },
      ],
    };
  },
};
</script>
